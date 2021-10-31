using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Akatsuki_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool SignUp(int sNum, string sAddress, string sEmail, string personalEmail, int cellphoneNum, string fName, string lName, string password);

        [OperationContract]
        bool Add_To_Cart_Service(int sNUm, int ServiceID, int ItemQuantity);

        [OperationContract]
        bool Add_To_Cart_Product(int sNUm, int ProductID, int ItemQuantity);

        [OperationContract]
        bool Update_Cart_Product(int sNUm,int ItemQuantity);

        [OperationContract]
        bool Update_Cart_Service(int sNUm, int ItemQuantity);



        [OperationContract]
        bool deleteGoodCart(int goodID);

        [OperationContract]
        bool deleteServiceCart(int ServiceID);
        [OperationContract]
        bool UpdateUserDetails(int sNum, string sAddress, string sEmail, string personalEmail, int cellphoneNum, string fName, string lName, string password);





        [OperationContract]
        string SignIn(string email,string password);

        [OperationContract]
        List<Good> getGoodsList();

        [OperationContract]
        Good getGoodItem(int ID);
        [OperationContract]
        Student getSingleStudent(int ID);


        [OperationContract]
        List<Service> getServicesList();

        [OperationContract]
        List<ProductCart> getProductCartList();


        [OperationContract]
        List<ServiceCart> getServiceCartList();





        [OperationContract]
        Service getServiceItem(int ID);

        [OperationContract]
        bool editGoodItem(int goodID, string gName, decimal gPrice, string gdescription);

        [OperationContract]
        bool addGood(int studentNum, string gName, decimal gPrice, string gdescription, string gImage, string gcategory);
        [OperationContract]
        bool deleteGood(int goodID);

        [OperationContract]
        bool editServiceItem(int serviceID, string sName, decimal sPrice, string sdescription);

        [OperationContract]
        bool addService(int studentNum, string sName, decimal sPrice, string sdescription, string sImage, string scategory);
        [OperationContract]
        bool deleteService(int serviceID);
        [OperationContract]
        List<ServiceReview> getServiceReviews();
        [OperationContract]
        List<GoodReview> getGoodReviews();
        [OperationContract]
        GoodReview getGoodReview(int goodID);
        [OperationContract]
        ServiceReview getServiceReview(int serviceID);
    }




   
}
