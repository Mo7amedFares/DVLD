using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class LocalDrivingLicenseService : RequestService
    {
        public int Local_Driving_License_Id { get; set; }
        public int Request_id { get; set; }
        public int License_Class_ID { get; set; }
        enum enAddOrUpdate
        {
            Add,
            Update
        }
        enAddOrUpdate AddOrUpdate;

        public LocalDrivingLicenseService(int Requst_id , int? Base_Request_ID, int user_id, DateTime date, enState state, int created_by_system_user, decimal paidFees, int License_Class_ID) : base(Base_Request_ID, user_id, date, state, created_by_system_user, paidFees, 1)
        {
            AddOrUpdate = enAddOrUpdate.Update;
            this.Request_id = Requst_id;
            this.License_Class_ID = License_Class_ID;
        }
        public LocalDrivingLicenseService(int Requst_id) : base(Requst_id)
        {
            AddOrUpdate = enAddOrUpdate.Update;
            this.Request_id = Requst_id;
            loadLocalDrivingLicense();
        }

        private void loadLocalDrivingLicense()
        {
            DataTable dt = DVLD_DataAccessLayer.LocalDrivingLicenseRepository.GetRequestLocalDrivingLicenseByID(this.Request_ID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                this.Local_Driving_License_Id = (int)row["Local_Driving_License_Id"];
                this.Request_id = Request_ID;
                this.License_Class_ID = (int)row["License_Class_ID"];
            }
        }

        public LocalDrivingLicenseService(int? Base_Request_ID, int user_id, DateTime date, enState state, int created_by_system_user, decimal paidFees, int License_Class_ID) : base(Base_Request_ID, user_id, date, state, created_by_system_user, paidFees, 1)
        {
            AddOrUpdate = enAddOrUpdate.Add;
            this.License_Class_ID = License_Class_ID;
        }
        public static DataTable GetAllRequestLocalDrivingLicense()
        {
            return DVLD_DataAccessLayer.LocalDrivingLicenseRepository.GetAllRequestLocalDrivingLicense();
        }
        public static DataTable GetRequestLocalDrivingLicenseByID(int Request_ID)
        {
            return DVLD_DataAccessLayer.LocalDrivingLicenseRepository.GetRequestLocalDrivingLicenseByID(Request_ID);
        }

        public LocalDrivingLicenseService GetLocalDrivingLicenseByID(int Request_ID)
        {
            DataTable dt = DVLD_DataAccessLayer.LocalDrivingLicenseRepository.GetRequestLocalDrivingLicenseByID(Request_ID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new LocalDrivingLicenseService(Request_ID, row["Base_Request_ID"] as int?, (int)row["user_id"], (DateTime)row["Date"], (enState)(int)row["State"], (int)row["created_by_system_user"], (decimal)row["PaidFees"], (int)row["License_Class_ID"]);
            }
            return null;
        }

        public LocalDrivingLicenseService GetLocalDrivingLicenseByUserID(int user_id)
        {
            DataTable dt = DVLD_DataAccessLayer.LocalDrivingLicenseRepository.GetRequestLocalDrivingLicenseByUserID(user_id);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new LocalDrivingLicenseService((int)row["Request_ID"], row["Base_Request_ID"] as int?, (int)row["user_id"], (DateTime)row["Date"], (enState)(int)row["State"], (int)row["created_by_system_user"], (decimal)row["PaidFees"], (int)row["License_Class_ID"]);
            }
            return null;
        }
        private bool AddLocalDrivingLicense()
        {
            int? requestId = base.AddRequest();
            if (requestId.HasValue)
            {
                this.Request_id = requestId.Value;
                this.License_Class_ID = DVLD_DataAccessLayer.LocalDrivingLicenseRepository.AddLocalDrivingLicense(this.Request_id, this.License_Class_ID);
                return this.License_Class_ID > 0;
            }
            return false;
        }

        private bool UpdateLocalDrivingLicense()
        {
            //if (base.UpdateRequest())
            //{
                return DVLD_DataAccessLayer.LocalDrivingLicenseRepository.UpdateLocalDrivingLicense(this.Request_id, this.License_Class_ID);
            //}
            //return false;
        }

        public bool UpdateLocalDrivingLicense(int Request_id, int License_Class_ID)
        {
            this.Request_id = Request_id;
            this.License_Class_ID = License_Class_ID;
            return UpdateLocalDrivingLicense();

        }

       

        public bool isAlreadyHaveSameClassLicense()
        {
            DataTable dt = DVLD_BusinessLogicLayer.LocalDrivingLicenseService.GetRequestLocalDrivingLicenseByID(this.user_id);
            string filter = $"License_Class_ID = {this.License_Class_ID} AND State IN ({(int)DVLD_BusinessLogicLayer.RequestService.enState.New}, {(int)DVLD_BusinessLogicLayer.RequestService.enState.Completed})";
            DataRow[] rows = dt.Select(filter);
            return rows.Length > 0;
        }

        public bool Save()
        {
            if (AddOrUpdate == enAddOrUpdate.Add)
            {
                return AddLocalDrivingLicense();
            }
            else
            {
                return UpdateLocalDrivingLicense();
            }
        }
    }
}
    