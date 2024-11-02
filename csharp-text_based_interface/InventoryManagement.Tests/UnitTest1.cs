using System;
using System.Collections.Generic;
using InventoryLibrary;
using NUnit.Framework;

namespace InventoryManager.Tests
{
    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void CreateObject_Should_Create_A_User_With_Specified_Name()
        {
            var user = new User("TestUser");
            Assert.That(user.Name, Is.EqualTo("TestUser"));
        }

        [Test]
        public void CreateItem_Should_Create_An_Item_With_Specified_Attributes()
        {
            var item = new Item("TestItem")
            {
                Description = "TestDescription",
                Price = 10.5f,
                Tags = new List<string> { "Tag1", "Tag2" }
            };
            Assert.Multiple(() =>
            {
                Assert.That(item.Name, Is.EqualTo("TestItem"));
                Assert.That(item.Description, Is.EqualTo("TestDescription"));
                Assert.That(item.Price, Is.EqualTo(10.5f));
                Assert.That(item.Tags, Does.Contain("Tag1"));
                Assert.That(item.Tags, Does.Contain("Tag2"));
            });
        }

        [Test]
        public void CreateInventory_Should_Create_Inventory_With_Specified_UserId_ItemId_And_Quantity()
        {
            var inventory = new Inventory("UserId1", "ItemId1", 5);
            Assert.Multiple(() =>
            {
                Assert.That(inventory.UserId, Is.EqualTo("UserId1"));
                Assert.That(inventory.ItemId, Is.EqualTo("ItemId1"));
                Assert.That(inventory.Quantity, Is.EqualTo(5));
            });
        }

        [Test]
        public void SetItemPrice_With_Invalid_Format_Should_Throw_FormatException()
        {
            var item = new Item("TestItem");
            Assert.Throws<FormatException>(() => { item.Price = float.Parse("InvalidPrice"); });
        }

        [Test]
        public void AddTag_Should_Add_Tag_To_Item()
        {
            var item = new Item("TestItem");
            item.Tags.Add("NewTag");
            Assert.That(item.Tags, Does.Contain("NewTag"));
        }

        [Test]
        public void RemoveTag_Should_Remove_Existing_Tag_From_Item()
        {
            var item = new Item("TestItem");
            item.Tags.Add("TagToRemove");
            item.Tags.Remove("TagToRemove");
            Assert.That(item.Tags.Contains("TagToRemove"), Is.False, "The tag was not removed.");
        }

        [Test]
        public void UpdateItemDescription_Should_Update_Description_Of_Item()
        {
            var item = new Item("TestItem") { Description = "OldDescription" };
            item.Description = "UpdatedDescription";
            Assert.That(item.Description, Is.EqualTo("UpdatedDescription"));
        }

        [Test]
        public void UpdateInventoryQuantity_Should_Change_Quantity_Of_Inventory()
        {
            var inventory = new Inventory("UserId1", "ItemId1", 5);
            inventory.Quantity = 10;
            Assert.That(inventory.Quantity, Is.EqualTo(10));
        }

        [Test]
        public void CreateUser_With_Empty_Name_Should_Throw_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new User(""));
        }

        [Test]
        public void CreateItem_With_Negative_Price_Should_Throw_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Item("TestItem") { Price = -5.0f });
        }

        [Test]
        public void CreateInventory_With_Negative_Quantity_Should_Throw_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Inventory("UserId1", "ItemId1", -3));
        }

        [Test]
        public void GetTags_Should_Return_All_Tags_Of_Item()
        {
            var item = new Item("TestItem");
            item.Tags.AddRange(new List<string> { "Tag1", "Tag2", "Tag3" });
            var tags = item.Tags;
            Assert.That(tags.Count, Is.EqualTo(3));
            Assert.That(tags, Does.Contain("Tag1"));
            Assert.That(tags, Does.Contain("Tag2"));
            Assert.That(tags, Does.Contain("Tag3"));
        }
    }
}
