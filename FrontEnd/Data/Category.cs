using System;
using System.Collections.Generic;

public class Category{
    public static Node rootNode;
    public static Dictionary<string, Node> nodeList;
    public static void Initialize(){
        nodeList = new();
        rootNode = new Node("Home", null);
        string[] children = {
            "Laptop",
            "Mackbook",
            "PC Components",
            "Screens",
            "Gaming Gears",
            "Audio",
            "Accessories",
            "Office Devices",
            "Network Devices"
        };
        rootNode.AddChildren(children);
        List<string[]> children2 = new List<string[]>(){
            new string[]{"Gaming Laptops", "Office Laptops"},
            new string[]{},
            new string[]{"CPU", "VGA", "Mainboard", "Cases", "PSU", "RAM", "SSD", "HDD", "Combos"},
            new string[]{"Gaming Screens", "Office Screens"},
            new string[]{"Mechanical keyboards", "Mousepads", "Microphones", "Gaming mouses", "Tables, chairs", "Headphones", "Stream Devices"},
            new string[]{"Speakers", "Wireless earbuds"},
            new string[]{"Air Coolers", "AIO Coolers", "Cooler Fans", "Risers", "VGA Holders"},
            new string[]{
                "Office Speakers", 
                "Copyright Software", 
                "Mouses, keyboards",
                "Wireless mouses, keyboards",
                "Laser Printers",
                "Webcams",
                "USB Hubs"
            },
            new string[]{"Wifi Routers", "Wifi Cards"}
        } ;
        for(int i = 0; i < children.Length; i++){
            rootNode.children[i].AddChildren(children2[i]);
        }
        Recur(rootNode);
    }
    static void Recur(Node node){
        nodeList.Add(node.value, node);
        if(node.children != null)
            foreach(var i in node.children)
                Recur(i);
    }
    public static List<string> GetTree(string val){
        var res = new List<string>();
        var node = nodeList[val];
        while(true){
            if(node == null) break;
            res.Insert(0, node.value);
            node = node.parent;
        }
        return res;
    }
}

public class Node{
    public List<Node> children;
    public Node parent;
    public string value;
    public Node(string v, Node p){
        children = new();
        parent = p;
        value = v;
    }
    public void AddChildren(string[] input){
        foreach(var i in input) children.Add(new Node(i, this));
    }
}