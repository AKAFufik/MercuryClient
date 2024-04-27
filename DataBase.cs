using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercuryClient
{
    internal class DataBase
    {
        private readonly OracleConnection _connection;
        public DataBase(string connectionString)
        {
            _connection = new OracleConnection(connectionString);
        }

        public void OpenConnection()
        {
            _connection.Open();

        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public OracleDataReader Pruduct()
        {
            var command = new OracleCommand("select t1.PRODUCTITEM_NAME AS \"Продукт\", t1.volume AS \"Вес\", t2.create_date AS \"Дата Добавления\", " +
                "t2.guid, t1.owner_doc_uuid AS UUID from BATCH t1 JOIN STOCK_ENTRY t2 ON t2.uuid = t1.owner_doc_uuid where t2.is_active=1", _connection);

            return command.ExecuteReader();
        }

        public OracleDataReader VSD()
        {
            var command = new OracleCommand("select t2.IN_OUT, t1.PRODUCTITEM_NAME AS \"Продукт\", t1.volume AS \"Вес\", " +
                "t2.issue_date AS \"Дата Выпуска\", t1.owner_doc_uuid AS UUID, t2.VSD_TYPE AS \"Тип ВСД\", " +
                "t2.VEHICLE_NUMBER AS \"Номер Автомобиля\", t2.TRANSPORT_STORAGE_TYPE AS \"Способ хранения\" " +
                "from BATCH t1 JOIN VSD t2 ON t2.uuid = t1.owner_doc_uuid where t2.LAST_CHANGE_DOC_UUID is NULL", _connection);

            return command.ExecuteReader();
        }

        public OracleDataReader VSDamping()
        {
            var command = new OracleCommand("select  t1.PRODUCTITEM_NAME AS \"Продукт\", t1.volume AS \"Вес\",t1.owner_doc_uuid AS UUID, " +
                "t2.DATE_START AS \"Начало Оформления\", t2.STATUS AS \"Статус\", t2.VEHICLE_NUMBER AS \"Номер Автомобиля\", " +
                "t2.TRANSPORT_STORAGE_TYPE AS \"Способ Хранения\", t2.WAYBILL_NUMBER AS \"Товарно-транспортная накладная\" " +
                "from BATCH t1 JOIN PREPARE_VSD t2 ON t2.uuid = t1.owner_doc_uuid", _connection);

            return command.ExecuteReader();
        }

        public string PrepareIncomingVSD(string l_PVSD_UUID)
        {
            //OracleCommand command = new OracleCommand("VETIS.PKG_VETIS_API_MMK_V2.PrepareIncomingVSD", _connection);
            /*OracleCommand command = _connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VETIS.PKG_VETIS_API_MMK_V2.PREPAREINCOMINGVSD";


            command.Parameters.Add("l_PVSD_UUID", OracleDbType.Varchar2, ParameterDirection.Input).Value = UUID;
            command.Parameters.Add("l_RetVal", OracleDbType.Varchar2, ParameterDirection.ReturnValue);
            command.ExecuteNonQuery();*/

            OracleCommand command = _connection.CreateCommand();
            command.CommandText = "BEGIN :1 := VETIS.PKG_VETIS_API_MMK_V2.PREPAREINCOMINGVSD(:l_PVSD_UUID); END;";


            OracleParameter retValParam = new OracleParameter(":1", OracleDbType.Varchar2, 32767);
            retValParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(retValParam);

            OracleParameter pvsdUuidParam = new OracleParameter(":l_PVSD_UUID", OracleDbType.Varchar2, 32767);
            pvsdUuidParam.Value = l_PVSD_UUID;
            command.Parameters.Add(pvsdUuidParam);
            command.ExecuteNonQuery();


            return retValParam.Value.ToString();
        }

        public void IncomeVSD(string l_PVSD_UUID)
        {
            OracleCommand command = _connection.CreateCommand();
            command.CommandText = "BEGIN VETIS.PKG_VETIS_API_MMK_V2.INCOMEVSD(:l_PPVSD_UUID); END;";


            OracleParameter pPvsdUuidParam = new OracleParameter(":l_PPVSD_UUID", OracleDbType.Varchar2, 32767);
            pPvsdUuidParam.Value = l_PVSD_UUID;
            command.Parameters.Add(pPvsdUuidParam);
            command.ExecuteNonQuery();
        }

        public string PrepareMergeStockEntry(string l_PFIRST_MERC_STOCK_ENTRY_UUID, string l_PSECOND_MERC_STOCK_ENTRY_UUID, string l_PTYPE_TRANSACT)
        {
            OracleCommand command = _connection.CreateCommand();
            command.CommandText = "BEGIN :1 := VETIS.PKG_VETIS_API_MMK_V2.PREPAREMERGESTOCKENTRY(:l_PFIRST_MERC_STOCK_ENTRY_UUID, :l_PSECOND_MERC_STOCK_ENTRY_UUID, :l_PTYPE_TRANSACT); END;";


            OracleParameter retValParam = new OracleParameter(":1", OracleDbType.Varchar2, 32767);
            retValParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(retValParam);

            OracleParameter pFirstMercStockEntryUuidParam = new OracleParameter(":l_PFIRST_MERC_STOCK_ENTRY_UUID", OracleDbType.Varchar2, 32767);
            pFirstMercStockEntryUuidParam.Value = l_PFIRST_MERC_STOCK_ENTRY_UUID;
            command.Parameters.Add(pFirstMercStockEntryUuidParam);

            OracleParameter pSecondMercStockEntryUuidParam = new OracleParameter(":l_PSECOND_MERC_STOCK_ENTRY_UUID", OracleDbType.Varchar2, 32767);
            pSecondMercStockEntryUuidParam.Value = l_PSECOND_MERC_STOCK_ENTRY_UUID;
            command.Parameters.Add(pSecondMercStockEntryUuidParam);

            OracleParameter pTypeTransactParam = new OracleParameter(":l_PTYPE_TRANSACT", OracleDbType.Varchar2, 32767);
            pTypeTransactParam.Value = l_PTYPE_TRANSACT;
            command.Parameters.Add(pTypeTransactParam);
            command.ExecuteNonQuery();

            return retValParam.Value.ToString();
        }

        public void MergeStockKEntry(string l_PPUUID)
        {
            OracleCommand command = _connection.CreateCommand();
            command.CommandText = "BEGIN VETIS.PKG_VETIS_API_MMK_V2.MERGESTOCKENTRY(:l_PPUUID); END;";

            OracleParameter pPuuidParam = new OracleParameter(":l_PPUUID", OracleDbType.Varchar2, 32767);
            pPuuidParam.Value = l_PPUUID;
            command.Parameters.Add(pPuuidParam);
            command.ExecuteNonQuery();

        }

        public List<VSD> FetchVSDs()
        {
            List<VSD> VSDs = new List<VSD>();
            OracleCommand command = new OracleCommand("select t1.PRODUCTITEM_NAME, t1.volume, t1.owner_doc_uuid AS UUID " +
                "from BATCH t1 JOIN VSD t2 ON t2.uuid = t1.owner_doc_uuid " +
                "where t2.LAST_CHANGE_DOC_UUID is NULL and t2.IN_OUT='INCOMING'", _connection);

            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    VSDs.Add(new VSD
                    {
                        Name = reader["PRODUCTITEM_NAME"].ToString(),
                        Volume = Convert.ToInt32(reader["VOLUME"]),
                        Uuid = reader["UUID"].ToString()
                    });
                }
            }
            return VSDs;
        }

        public OracleDataReader ExecuteReader(string sqlCommand)
        {
            var command = new OracleCommand(sqlCommand, _connection);
            return command.ExecuteReader();
        }
    }
}
