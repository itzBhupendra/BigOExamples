using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.AlgoExpert
{
    public class BST
    {
        public int value;
        public BST right;
        public BST left;
        public BST(int _value)
        {
            value = _value;
        }
        public BST Insert(int _value)
        {
            var currentNode = this;
            while (true)
            {
                if (_value < currentNode.value)
                {
                    //Left Node
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BST(_value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }

                }
                else
                {
                    //right Node
                    if (currentNode.right == null)
                    {
                        currentNode.right = new BST(_value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }

                }
            }
            return this;
        }

        public bool Contains(int _value)
        {
            var currentNode = this;
            while (currentNode != null)
            {
                if (_value < currentNode.value)
                {
                    // left

                    currentNode = currentNode.left;
                }
                else if (_value > currentNode.value)
                {
                    //right
                    currentNode = currentNode.right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public int GetMinValue()
        {
            return left?.GetMinValue() ?? value;
        }
        public BST Remove(int _value, BST parentNode = null)
        {
            var currentNode = this;
            while (currentNode != null)
            {
                if (_value < currentNode.value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.left;
                }

                else if (_value > currentNode.value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.right;
                }
                else
                {
                    if (currentNode.left != null && currentNode.right != null)
                    {
                        // Replace current value with Min value from right SubTree
                        currentNode.value = currentNode.right.GetMinValue();
                        currentNode.right.Remove(currentNode.value, currentNode);
                    }
                    else if (parentNode == null)
                    {
                        if (currentNode.left != null)
                        {
                            currentNode.value = currentNode.left.value;
                            currentNode.right = currentNode.left.right;
                            currentNode.left = currentNode.left.left;
                        }
                        else if (currentNode.right != null)
                        {
                            currentNode.value = currentNode.right.value;
                            currentNode.left = currentNode.right.left;
                            currentNode.right = currentNode.right.right;
                        }

                        else
                        {

                        }
                    }
                    else if (parentNode.left == currentNode)
                    {
                        parentNode.left = currentNode.left ?? currentNode.right;
                    }

                    else if (parentNode.right == currentNode)
                    {
                        parentNode.right = currentNode.left ?? currentNode.right;
                    }
                    break;

                }


            }
            return this;
        }


    }

    public class ClosestValueInBST
    {
        public static int findClosestValueInBST(BST tree, int target)
        {
            int value = -1;
            int NodeValue = 0;
            var currentNode = tree;

            while (currentNode!= null)
            {

                if (target > currentNode.value)
                {
                    if (value ==-1 || value > (target - currentNode.value  ))
                    {
                        value = target- currentNode.value;
                        NodeValue = currentNode.value;

                    }
                    currentNode = currentNode.right;
                }
                else
                {
                    if (value == -1 || value > (currentNode.value - target))
                    {
                        value = currentNode.value - target;
                        NodeValue = currentNode.value;

                    }
                    currentNode = currentNode.left;

                }
            }
            return NodeValue;
        }

    }
}
