using Data;
using Logic;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using XMLGenerator.MVVM;

namespace XMLGenerator
{
    public class ViewModel : ViewModelBase
    {
        private Author selectedAuthor;
        private Product selectedProduct;
        private Order selectedOrder;
        public ViewModel()
        {
            Click_Browse = new RelayCommand(Browse);
            Click_Serialize = new RelayCommand(SerializeTask);
            Click_AddAuthor = new RelayCommand(AddAuthor);
            Click_RemoveAuthor = new RelayCommand(RemoveAuthor);
            Click_AddProduct = new RelayCommand(AddProduct);
            Click_RemoveProduct = new RelayCommand(RemoveProduct);
            CreateMenuItems();
        }
        public string PathVariable { get; set; }
        public ICommand Click_Browse { get; }
        public ICommand Click_Serialize { get; }
        public ICommand Click_AddAuthor { get; }
        public ICommand Click_RemoveAuthor { get; }
        public ICommand Click_AddProduct { get; }
        public ICommand Click_RemoveProduct { get; }
        public Company CompanyGrid { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Author> Authors { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<UserPages> ListOfMenuItems { get; set; }
        public Author SelectedAuthor
        {
            get => selectedAuthor;
            set
            {
                selectedAuthor = value;
                RaisePropertyChanged(nameof(SelectedAuthor));
            }
        }
        public Product SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                RaisePropertyChanged(nameof(SelectedProduct));
            }
        }
        public Order SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                RaisePropertyChanged(nameof(SelectedOrder));
            }
        }
        private void CreateAuthors()
        {
            Authors = new ObservableCollection<Author>();
            foreach (Author author in CompanyGrid.Authors)
            {
                Authors.Add(author);
            }
            RaisePropertyChanged("Authors");
        }
        private void CreateProducts()
        {
            Products = new ObservableCollection<Product>();
            foreach (Product product in CompanyGrid.ProductsRepository)
            {
                Products.Add(product);
            }
            RaisePropertyChanged("Products");
        }
        private void CreateOrders()
        {
            Orders = new ObservableCollection<Order>();
            foreach (Order order in CompanyGrid.Orders)
            {
                Orders.Add(order);
            }
            RaisePropertyChanged("Orders");
        }
        private void AddAuthor()
        {
            Authors.Add(new Author("Forename", "Name", "Id"));
        }
        private void RemoveAuthor()
        {
            Authors.Remove(SelectedAuthor);
        }
        private void AddProduct()
        {
            Products.Add(new Product("Name", 0));
        }
        private void RemoveProduct()
        {
            Products.Remove(SelectedProduct);
        }
        private void Browse()
        {
            PathVariable = OpenDialogPath.GetPath();
            if (PathVariable != null)
            {
                CompanyGrid = XmlSerialization.Deserialize(PathVariable);
            }
            CreateProducts();
            CreateAuthors();
            CreateOrders();
        }
        private void SerializeTask()
        {
            Company company = new Company(Orders.ToList(), Products.ToList(), Authors.ToList(), "zam schema.xsd");
            XmlSerialization.Serialize(company, "nowy.xml");
        }
        private void CreateMenuItems()
        {
            ListOfMenuItems = new ObservableCollection<UserPages>() { new UserPages("Authors", new Authors()),  new UserPages("Products", new Products()),
                new UserPages("Orders", new Orders()) };
            RaisePropertyChanged("ListOfMenuItems");
        }
    }
}
