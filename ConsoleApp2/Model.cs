using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Model
    {
        private Node rootNode;

        public Model()
        {
            // Code for setting up testing base, this sould be removed or changed later
            this.setRootNode(new Node(0));
            this.addNewNodeToExistingNode(rootNode, new Node(5), "right");
            this.addNewNodeToExistingNode(rootNode, new Node(-2), "left");
            Console.WriteLine(rootNode.toString());

        }

        // Method for controlling the flow of the program
        private void ProgramFlow()
        {
            bool running = true;
            while (running)
            {

            }
        }

        // Adding new node to specific position
        private void addNewNodeToExistingNode(Node existingNode, Node newNode, String direction)
        {
            if (direction == "left")
            {
                existingNode.setLeftNode(newNode);
            }
            else
            {
                existingNode.setRightNode(newNode);
            }
        }

        // Method for add new nodes based on search tree rules
        private void addNewNode(Node newNode)
        {

        }

        // Recursive method for printing all nodes
        private void printAllNodes()
        {

        }

        // Method for finding specific node by value
        private Node FindNodeByValue(int searchValue)
        {
            return null;
        }

        private void setRootNode(Node newRootNode)
        {
            this.rootNode = newRootNode;
        }
    }
}
