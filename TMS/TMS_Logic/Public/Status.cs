using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Logic.Public
{
    public class Status
    {
        #region--Form_Main_root--
        public static int Current_id { get; set; }//标识用户id 0->root 1->teacher 2->student
        
        #endregion

        public static bool SelectChangeStatus { get; set; }//显示设置信息是否变动 true->变 false->未变
        #region--Form_StudentMS_root--
        public static bool Form_selectItemsCreateStatus { get; set; }//Form_SelectItems是否创建 true->已建 false->未建
        public static bool Form_StudentMS_rootEditStatus { get; set; }//是否可以编辑 ture->可 false->不可
        public static bool Form_SelectEditStatus { get; set; }//Form_SelectEditStatus是否创建 true->已建 false->未建
        public static long BeforeIndex { get; set; }//记录DGV_studentInfo上一个索引
        public static bool EdittingStatus { get; set; }//标识是否正在编辑 true->编辑中 false->未编辑
        public static bool IsAdding_Status { get; set; }//标识是否添加状态 true->是 false->否
        #endregion

        #region--Form_Main_root--
        public static bool Form_RootCreateStatus { get; set; }//Form_StudentMS_rootCreateStatus是否创建 true->已建 false->未建
        #endregion
    }
}
