namespace RandomSelection{
    public class Organ{
      
        #region Source Database
        /// <summary>统一社会信用代码(或组织机构代码)</summary>
        public string Id{get;set;}
        /// <summary>机构名称</summary>
        public string Name{get;set;}
        /// <summary>联系人</summary>
        public string Staff{get;set;}
        /// <summary>联系电话</summary>
        public string Phone{get;set;}
        /// <summary>注册地址</summary>
        public string Address{get;set;}
        /// <summary>登记日期</summary>
        public string RegDate{get;set;}
        /// <summary>登记地点</summary>
        public string RegLocation{get;set;}
        /// <summary>备注</summary>
        public string Remark{get;set;}
        #endregion
        public Organ()
        {
           
        }
        public Organ(string[] array){
            if (array.Length != 8) return;
            Id = array[0];
            Name= array[1];
            Staff= array[2];
            Phone = array[3];
            Address = array[4];
            RegDate = array[5];
            RegLocation = array[6];
            Remark = array[7];
        }
        public Organ(Organ organ)
        {
            if (organ==null) return;
            Id = organ.Id;
            Name = organ.Name;
            Staff = organ.Staff;
            Phone = organ.Phone;
            Address = organ.Address;
            RegDate = organ.RegDate;
            RegLocation = organ.RegLocation;
            Remark = organ.Remark;
        }
    }
    public class Log {
        /// <summary>统一社会信用代码(或组织机构代码)</summary>
        public string Id { get; set; }
        /// <summary>机构名称</summary>
        public string Name { get; set; }
        /// <summary>联系人</summary>
        public string Staff { get; set; }
        /// <summary>联系电话</summary>
        public string Phone { get; set; }
        public string DateTime { get; set; }
    }
}