/**
* Namespace: UseMVVMlight.ViewModel
*
* Functon： N/A
* Class Name： StudentViewModel
*
* Ver Change Date; Responsible person; Change content;
* ───────────────────────────────────
* V0.01; 2016/10/8 15:18:30; JiaMZ;   first edition;
*
* Copyright (c) 2016 JiaMZ. All rights reserved.
*┌────────────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　            │
*│　版权所有： │
*└────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace UseMVVMlight {
    public class StudentViewModel:ViewModelBase {
        public StudentViewModel() {
            styleNum = 0.5;
            stuList = new List<Student>();
            GetData();
        }
        #region memeber
        private List<Student> stuList;
       
        

        public List<Student> StuList {
            get {
                return stuList;
            }

            set {
                stuList = value;
                if (stuList != value) {
                    stuList = value;
                    RaisePropertyChanged("StuList");
                }
            }
        }
        private Student selectStu;
        public Student SelectStu {
            get {
                return selectStu;
            }

            set {
                if (selectStu != value) {
                    selectStu = value;
                    RaisePropertyChanged("SelectStu");
                }
               
            }
        }
        private double styleNum;
        public double StyleNum {
            get {
                return styleNum;
            }

            set {
                if (styleNum != value) {
                    styleNum = value;
                    RaisePropertyChanged("StyleNum");
                }
            }
        }

        #endregion
        private void GetData() {
            for (int i = 0; i < 10; i++) {
                StuList.Add(new Student("name: "+i,i.ToString(),"male","add: "+i+ " 号"));
            }
        }
    }
}
