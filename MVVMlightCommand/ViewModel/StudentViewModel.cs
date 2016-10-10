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
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace MVVMlightCommand {
    public class StudentViewModel:ViewModelBase {
        public StudentViewModel() {
            styleNum = 0.5;
            stuList = new ObservableCollection<Student>();
            GetData();
            DeleteCommand = new RelayCommand(Delete, CanExe);
        }

        public ICommand DeleteCommand { get; private set; }


        #region memeber
        private ObservableCollection<Student> stuList;
        public ObservableCollection<Student> StuList {
            get {
                return stuList;
            }

            set {
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

        
        public void Delete() {
            StuList.Remove(SelectStu);
        }
        private bool CanExe() {
            return StuList.Count > 7;
        }
        private void GetData() {
            for (int i = 0; i < 10; i++) {
                StuList.Add(new Student("name: "+i,i.ToString(),"male","add: "+i+ " 号"));
            }
        }
    }
}
