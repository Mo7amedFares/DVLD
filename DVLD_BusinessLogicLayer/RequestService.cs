using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class RequestService
    {
        public enum enState
        {
            New = 1,
            cancelled = 2,
            Completed = 3
        };
        private enState enstate;
        public int Request_ID { get; set; }
        public int? Base_Request_ID { get; set; }
        public int user_id { get; set; }
        public DateTime Date { get; set; }
        public int State { get; set; }
        public int created_by_system_user { get; set; }
        public decimal PaidFees { get; set; }
        public int RequestTypeID { get; set; }

        public RequestService(int? Base_Request_ID, int user_id, DateTime date, enState state, int created_by_system_user, decimal paidFees, int requestType)
        {
            enstate = enState.New;
            this.Base_Request_ID = Base_Request_ID;
            this.user_id = user_id;
            this.Date = date;
            this.State = (int)state;
            enstate = state;
            this.created_by_system_user = created_by_system_user;
            this.PaidFees = paidFees;
            this.RequestTypeID = requestType;
        }

        public RequestService(int Request_ID){ 
            this.Request_ID = Request_ID;
            LoadRequest();
        }

        private void LoadRequest()
        {
            DataTable request = DVLD_DataAccessLayer.RequestRepository.GetRequestByID(this.Request_ID);
            if(request.Rows.Count > 0)
            {
                DataRow row = request.Rows[0];
                this.Base_Request_ID = row["Base_Request_ID"] as int?;
                this.user_id = (int)row["user_id"];
                this.Date = (DateTime)row["Date"];
                this.State = (int)row["State"];
                enstate = (enState)this.State;
                this.created_by_system_user = (int)row["created_by_system_user"];
                this.PaidFees = (decimal)row["PaidFees"];
                this.RequestTypeID = (int)row["RequestTypeID"];
            }
        }

        protected int? AddRequest()
        {
            return DVLD_DataAccessLayer.RequestRepository.AddRequest(this.Base_Request_ID, this.user_id, this.Date, this.State, this.created_by_system_user, this.PaidFees, this.RequestTypeID);
        }
        protected bool UpdateRequest()
        {
            return DVLD_DataAccessLayer.RequestRepository.UpdateRequest(this.user_id, this.Base_Request_ID, this.user_id, this.Date, this.State, this.created_by_system_user, this.PaidFees, this.RequestTypeID);

        }


        public bool ChangeRequestState()
        {
            enstate = (enState)this.State;
            return DVLD_DataAccessLayer.RequestRepository.ChangeRequestState(this.Request_ID, (int)enstate);
        }
    }
}
