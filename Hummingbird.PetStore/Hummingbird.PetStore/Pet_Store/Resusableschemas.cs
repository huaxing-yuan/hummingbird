
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{

    [Serializable]
    /// <summary>
    /// </summary>
    public class Order{
        public long id {get; set;} 

        public long petId {get; set;} 

        public int quantity {get; set;} 

        public DateTime shipDate {get; set;} 

        public Hummingbird.PetStore.Pet_Store.Pet_Store.status status {get; set;} 

        public bool complete {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    public class User{
        public long id {get; set;} 

        public string username {get; set;} 

        public string firstName {get; set;} 

        public string lastName {get; set;} 

        public string email {get; set;} 

        public string password {get; set;} 

        public string phone {get; set;} 

        public int userStatus {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    public class Category{
        public long id {get; set;} 

        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    public class Tag{
        public long id {get; set;} 

        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    public class Pet{
        public long id {get; set;} 

        public Hummingbird.PetStore.Pet_Store.Pet_Store.Category category {get; set;} 

        public string name {get; set;} 

        public string[] photoUrls {get; set;} 

        public Hummingbird.PetStore.Pet_Store.Pet_Store.Tag[] tags {get; set;} 

        public Hummingbird.PetStore.Pet_Store.Pet_Store.status_1 status {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    public class ApiResponse{
        public int code {get; set;} 

        public string type {get; set;} 

        public string message {get; set;} 

    }

}
