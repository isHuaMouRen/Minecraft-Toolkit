using MinecraftToolkit.Pages;
using ModernWpf.Controls;
using ModernWpf.Media.Animation;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static MinecraftToolkit.Class.Globals.Obj;

namespace MinecraftToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Obj
        private Dictionary<string, Type> PageMap = new Dictionary<string, Type>();//预加载Pages
        private DrillInNavigationTransitionInfo FrameAnimation = new DrillInNavigationTransitionInfo();
        #endregion

        #region Func
        public void Initialize()
        {
            try
            {
                logger.Info($"{this.Name} 开始初始化");

                //预加载Page
                void AddPage(Type t) {
                    PageMap.Add(t.Name, t);
                    logger.Info($"添加 {t.Name} 进入预加载PageMap");
                };
                AddPage(typeof(PageHome));


                //选择默认page
                navView.SelectedItem = navViewItem_Home;

                logger.Info($"{this.Name} 完成初始化");
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void navView_SelectionChanged(ModernWpf.Controls.NavigationView sender, ModernWpf.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            try
            {
                if (navView.SelectedItem is NavigationViewItem item)
                {
                    logger.Info($"用户选择: {item.Tag} 页");

                    frame.Navigate(PageMap[$"Page{item.Tag}"], null, FrameAnimation);
                }
                else
                    throw new Exception("非法的值");
            }
            catch (Exception ex)
            {
                logger.Error("fas fasasfdfasdfasdfasfas");
            }
        }
    }
}