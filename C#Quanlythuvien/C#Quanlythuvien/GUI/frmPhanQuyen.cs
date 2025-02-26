using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhanQuyen : Form
    {
        public string maQ = "";
        public frmPhanQuyen(string maQ)
        {
            InitializeComponent();
            setEventTreeView();
            this.maQ = maQ;
        }
        public event EventHandler btn_CapNhat_Clicked;
        private void Onbtn_CapNhat_Clicked()
        {
            btn_CapNhat_Clicked?.Invoke(this, EventArgs.Empty);
        }
        public bool IsFirstNodeChecked(TreeView treeView)
        {
            if (treeView.Nodes[0].Checked)
            {
                return true;
            }
            return false;
        }
        public bool IsCheckAtLeastOneNode(TreeView treeView)
        {
            foreach (TreeNode childNode in treeView.Nodes[0].Nodes)
            {
                if (childNode.Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_hoanTat_Click(object sender, EventArgs e)
        {
            if (IsFirstNodeChecked(treeView7))
            {
                if (!IsCheckAtLeastOneNode(treeView7))
                {
                    MessageBox.Show("Chức Năng Nhập Hàng Phải Chọn Ít Nhất 1 Tác Vụ", "Thông Báo");
                    return;
                }
            }
            if (!getNutGoc(treeView2).Checked && (getNutGoc(treeView12).Checked ||
                getNutGoc(treeView11).Checked || getNutGoc(treeView9).Checked))
            {
                MessageBox.Show("Bắt Buộc Phải Chọn Chức Năng Sách Trước", "Thông Báo");
                return;
            }
            bool check = false;
            List<TreeView> listTreeView = getListTreeView();
            List<TreeNode> listNutGoc = new List<TreeNode>();
            foreach(TreeView treeView in listTreeView)
            {
                TreeNode nutGoc = getNutGoc(treeView);
                listNutGoc.Add(nutGoc);
            }
            foreach(TreeNode node in listNutGoc)
            {
                if (node.Checked)
                {
                    check= true;    
                }
            }
            if (check)
            {
                for (int i = 0; i < listTreeView.Count; i++)
                {
                    int adjustedIndex = i + 1;
                    string index = (adjustedIndex < 10) ? $"CN0{adjustedIndex}" : $"CN{adjustedIndex}";
                    string maCN = index;
                    TreeNode nutGoc = getNutGoc(listTreeView[i]);
                    if (nutGoc.Checked)
                    {
                        if (KiemTraTonTai(this.maQ, maCN))
                        {
                            string chiTiet = "";
                            List<TreeNode> nodes = GetChildNodes(listTreeView[i]);
                            chiTiet = getChiTiet(nodes);
                            ChiTietChucNang ctcn = new ChiTietChucNang(maCN, maQ, chiTiet);
                            busCTCN.update(ctcn);
                        }
                        else
                        {
                            string chiTiet = "";
                            List<TreeNode> nodes = GetChildNodes(listTreeView[i]);
                            chiTiet = getChiTiet(nodes);
                            ChiTietChucNang ctcn = new ChiTietChucNang(maCN, maQ, chiTiet);
                            busCTCN.insert(ctcn);
                        }
                    }
                    else
                    {
                        if (KiemTraTonTai(maQ, maCN))
                        {
                            busCTCN.delete(maCN, maQ);
                        }
                    }
                }
                MessageBox.Show("Thành Công!", "Thông Báo");
                Onbtn_CapNhat_Clicked();
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 quyền","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string getChiTiet(List<TreeNode> list)
        {
            string chiTiet = "";
            foreach (TreeNode node in list)
            {
                if (node.Checked)
                {
                    chiTiet += node.Text+" ";
                }
            }
            return chiTiet;
        }

        public bool KiemTraTonTai(string maQ,string maCN)
        {
            List<ChiTietChucNang> list = busCTCN.getAllChucNangByMaQuyen(maQ);
            for(int i =0; i < list.Count; i++)
            {
                if (maCN == list[i].SGMaCN)
                {
                    return true;
                }
            }
                return false;
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {

        }
        ChucNangBUS busCN = new ChucNangBUS();
        NhomQuyenBUS busNQ = new NhomQuyenBUS();
        ChiTietChucNangBUS busCTCN = new ChiTietChucNangBUS();
       
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
        // ham lay toan bo treeview co trong form
        public List<TreeView> getListTreeView()
        {
            List<TreeView> list = new List<TreeView>();
            for (int i = 1; i < 13; i++)
            {
                list.Add(treeView1);
                list.Add(treeView2);
                list.Add(treeView3);
                list.Add(treeView6);
                list.Add(treeView4);
                list.Add(treeView5);
                list.Add(treeView7);
                list.Add(treeView8);
                list.Add(treeView12);
                list.Add(treeView11);
                list.Add(treeView10);
                list.Add(treeView9);
                list.Add(treeView13);
            }

            return list;
        }
        // ham lay toan bo treenode(nhung k xai)
        public List<TreeNode> getlistTreeNode(List<TreeView> treeViews)
        {
            List<TreeNode> rootNodesList = new List<TreeNode>();

            foreach (TreeView treeView in treeViews)
            {
                if (treeView.Nodes.Count > 0)
                {
                    // Lấy RootNode từ TreeView và thêm vào danh sách
                    TreeNode rootNode = treeView.Nodes[0];
                    rootNodesList.Add(rootNode);
                }
            }
            return rootNodesList;
        }

        public void setThongTin(string maQuyen)
        {
            List<string> list = new List<string>();
            list = busCTCN.getMaCNbyMaQuyen(maQuyen);
            List<TreeView> treeViews = getListTreeView();
            List<TreeNode> rootNodesList = getlistTreeNode(treeViews);
            foreach (string item in list)
            {
                int index = int.Parse(item.Substring(2)) - 1;

                if (index >= 0 && index < rootNodesList.Count)
                {
                    rootNodesList[index].Checked = true;
                }
            }
        }


        // lay node con cua 1 tree view 
        private List<TreeNode> GetChildNodes(TreeView treeView)
        {
            List<TreeNode> childNodes = new List<TreeNode>();

            // Kiểm tra xem TreeView có nút gốc không
            if (treeView.Nodes.Count > 0)
            {
                // Lấy nút gốc
                TreeNode rootNode = treeView.Nodes[0];

                // Kiểm tra xem nút gốc có nút con không
                if (rootNode.Nodes.Count > 0)
                {
                    // Lấy danh sách nút con và thêm vào childNodes
                    foreach (TreeNode childNode in rootNode.Nodes)
                    {
                        childNodes.Add(childNode);
                    }
                }
            }

            return childNodes;
        }
        public TreeNode getNutGoc(TreeView treeView)
        {
                return treeView.Nodes[0]; 
        }


        private List<TreeNode> GetAllChildNodes(List<TreeView> treeViews)
        {
            List<TreeNode> allChildNodes = new List<TreeNode>();

            foreach (TreeView treeView in treeViews)
            {
                List<TreeNode> childNodes = GetChildNodes(treeView);
                allChildNodes.AddRange(childNodes);
            }

            return allChildNodes;
        }

        // ham set thong tin cac child nodes
        // ffffffffffffffffffff
        public void setThongTinCacChildNode(string maQuyen)
        {
           List<ChiTietChucNang> listChiTietChucNang = busCTCN.getAllChucNangByMaQuyen(maQuyen);
           List<TreeView> listTreeView = getListTreeView();
           
           foreach(ChiTietChucNang ctcn in listChiTietChucNang)
            {
                int index = int.Parse(ctcn.SGMaCN.Substring(2))-1;
                List<TreeNode> getChildNodes = GetChildNodes(listTreeView[index]);
                checkNeuNhuTonTai(getChildNodes,ctcn.SGChiTiet);

            }

        }
        public void checkNeuNhuTonTai(List<TreeNode> list,string chiTiet)
        {
            foreach(TreeNode node in list)
            {
                if (chiTiet.ToLower().Contains(node.Text.ToLower()))
                {
                    node.Checked = true;
                }
            }
        }


        public void setEventTreeView()
        {
            List<TreeView> treeViews = getListTreeView();
            foreach (TreeView treeView in treeViews)
            {
                treeView.BeforeCheck += TreeView_BeforeCheck;
            }
        }







        private void TreeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            // Check if the node being checked is a child node
            if (e.Node.Parent != null && e.Node.Parent.Checked)
            {
                // Allow checking child nodes when the parent node is checked
                e.Cancel = false;
            }
            else if (e.Node.Parent == null)
            {
                // Allow checking the root node
                e.Cancel = false;
            }
            else
            {
                // Cancel checking for other cases
                e.Cancel = true;
            }
        }
       
        private void treeView6_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

   
    }
}
