using aspmvccore6test1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace aspmvccore6test1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult declaration()
        {
            return View();
        }

        public IActionResult information()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Details()
        {


            Product? product = ProductDataAccessLayer.GetStudentData();
            ViewData["A"] = ProductDataAccessLayer.GetStudentData();
            ViewData["B"] = "ASJHSDKJF";
            ViewData["C"] = GVariable.product_NOP[0];

            return View();
        }


        //linked list test
        public IActionResult multitree_test()
        {
            var linkedList = new LinkedLists<int?>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);


            ViewData["1"] = linkedList.Head.Value;
            //ViewData["2"] = linkedList;
            linkedList.Print();

            ViewData["2"] = GVariable.linklistvar[0];

            return View();

            //// 構建多元樹結構
            //var rootNode = new TreeNode
            //{
            //    Id = 1,
            //    Value = "Root",
            //    Child = new TreeNode
            //    {
            //        Id = 2,
            //        Value = "Child 1",
            //        Child = new TreeNode
            //        {
            //            Id = 4,
            //            Value = "Grandchild 1"
            //        }
            //    }
            //};

        }


        //multiway tree a b c sample test
        public IActionResult mutitree1()
        {
            //TREE TEST
            //多元樹測試
            MultiTree<string> tree = new MultiTree<string>();

            tree.AddNode("A", default);
            //AddNode(newnode,parrentnode);
            tree.AddNode("B", "A");
            tree.AddNode("C", "A");
            tree.AddNode("D", "B");
            tree.AddNode("E", "B");
            tree.AddNode("F", "C");

            tree.PrintTree();
            Console.WriteLine("第一階段建值測試");

            tree.RemoveNode("D");
            tree.PrintTree();
            Console.WriteLine("第二階段珊除末葉測試");

            tree.RemoveNode("B");
            tree.PrintTree();
            Console.WriteLine("第三階段刪除節點子節點會不會同步刪除");



            tree.AddNode("B", "A");
            tree.AddNode("C", "A");

            tree.AddNode("B", "A");
            tree.AddNode("C", "A");
            tree.AddNode("Q", "B");
            tree.AddNode("R", "B");

            tree.AddNode("S", "R");
            tree.AddNode("T", "S");

            tree.AddNode("U", "S");

            tree.AddNode("V", "S");

            tree.AddNode("X", "Q");

            tree.AddNode("S", "Q");
            tree.PrintTree();
            Console.WriteLine("第四階段同意節點接兩個不同父節點");
            Console.WriteLine("測試失敗須對資料作調整以SLOT為標記可以改善");


            //to html variable
            ViewData["5"] = GVariable.multiwaytree_list[0];
            ViewData["6"] = GVariable.multiwaytree_list[1];
            ViewData["7"] = GVariable.multiwaytree_list[2];



            return View();
        }

        //multiway tree simulate sql data
        public IActionResult treecsql()
        {
            //TREE TEST

            MultiTree<string> tree = new MultiTree<string>();

            tree.AddNode("1_BODY0000001_5_H1-H2-H2-L1-L1_NULL_NULL", default);
            //AddNode(newnode,parrentnode);
            tree.AddNode("2_HEAD0000001_1_H1_1_1", "1_BODY0000001_5_H1-H2-H2-L1-L1_NULL_NULL");
            tree.AddNode("3_LEFTARM0000001_2_H2-H2_2_1", "1_BODY0000001_5_H1-H2-H2-L1-L1_NULL_NULL");
            tree.AddNode("4_LEFTARM0000001_2_H2-H2_3_1", "1_BODY0000001_5_H1-H2-H2-L1-L1_NULL_NULL");
            tree.AddNode("5_LEFTARM0000001_2_H2-H2_2_1", "4_LEFTARM0000001_2_H2-H2_3_1");
            tree.PrintTree();
            Console.WriteLine("基本給值測試正常");
            tree.RemoveNode("4_LEFTARM0000001_2_H2-H2_3_1");
            tree.PrintTree();
            Console.WriteLine("刪除測試正常");



            //to html variable
            ViewData["5"] = GVariable.multiwaytree_list[0];
            ViewData["6"] = GVariable.multiwaytree_list[1];
            ViewData["7"] = GVariable.multiwaytree_list[2];


            return View();
        }
    }
}
