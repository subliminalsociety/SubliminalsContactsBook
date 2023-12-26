using System;

namespace FormsUI
{
    public class ContactsDatabase
    {
        public static int RandomNumberOfContacts = 10;

        private readonly Contact _contactFour = new Contact(
            "Susan B. Nockingham",
            "913-321-7654",
            "bluejayinabluesky@hotmail.com ",
            "3141 South Nieman Road Apt #204" + Environment.NewLine + "Shawnee, KS 66203",
            "Unit Secretary",
            "Encompass Health Rehabilitation Hospital",
            "7/4/1983",
            "N/A");

        private readonly Contact _contactOne = new Contact(
            "Christian E. Menchue",
            "913-218-8061",
            "cmen1026@gmail.com",
            "559 North Mur-Len Road Apt #101" + Environment.NewLine + "Olathe, KS 66062",
            "Entrepreneur",
            "Recyclean Housekeeping LLC",
            "10/26/1998",
            "N/A");

        private readonly Contact _contactThree = new Contact(
            "George L. Scott ",
            "816-330-4779",
            "glscott72@yahoo.com ",
            "4682 Washington Blvd" + Environment.NewLine + "Kansas City, MO 78225",
            "Mechanic",
            "Scott's Auto Repair Shop",
            "4/15/1972",
            "N/A");

        private readonly Contact _contactTwo = new Contact(
            "Jazzmin A. Matchette",
            "480-881-8992",
            "jazzminmatchette27@gmail.com ",
            "559 North Mur-Len Road Apt #101" + Environment.NewLine + "Olathe, KS 66062",
            "Entrepreneur",
            "Recyclean Housekeeping LLC",
            "1/7/99",
            "N/A");

        public Contact[] ContactList;
        public Contact[] RandomContactList;

        private Contact[] PregenList()
        {
            return new[] { _contactOne, _contactTwo, _contactThree, _contactFour };
        }

        private Contact[] RandomList()
        {
            var num = RandomNumberOfContacts;
            var list = new Contact[num];
            for (var i = 0; i < num; i++)
            {
                var randContact = Contact.GenerateRandomContact();
                list[i] = randContact;
            }

            return list;
        }

        public void GenerateContacts()
        {
            ContactList = PregenList();
            RandomContactList = RandomList();
        }

        #region Singleton

        private static ContactsDatabase _instance;
        private static readonly object LockObject = new object();

        public static ContactsDatabase Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (LockObject)
                {
                    if (_instance == null)
                        // ReSharper disable once PossibleMultipleWriteAccessInDoubleCheckLocking
                        _instance = new ContactsDatabase();
                }

                return _instance;
            }
        }

        #endregion
    }
}