﻿namespace DevExpress.OutlookInspiredApp.Win.Modules {
    using DevExpress.OutlookInspiredApp.Win.Presenters;
    using DevExpress.OutlookInspiredApp.Win.ViewModel;
    using DevExpress.XtraLayout.Utils;

    public partial class EmployeesFilterPaneCollapsed : BaseModuleControl, ISupportCompactLayout {
        EmployeeFilterPanePresenter presenterCore;
        public EmployeesFilterPaneCollapsed(EmployeeCollectionViewModel collectionViewModel)
            : base(() => CreateViewModel(() => new EmployeesFilterTreeViewModel(collectionViewModel))) {
            InitializeComponent();
            presenterCore = CreatePresenter();
            BindCommands();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public EmployeesFilterTreeViewModel ViewModel {
            get { return GetViewModel<EmployeesFilterTreeViewModel>(); }
        }
        public EmployeeFilterPanePresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual EmployeeFilterPanePresenter CreatePresenter() {
            return new EmployeeFilterPanePresenter(navigationBar, ViewModel);
        }
        protected virtual void BindCommands() {
            btnNew.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
        }
        #region ISupportCompactLayout Members
        bool compactLayout = true;
        bool ISupportCompactLayout.Compact {
            get { return compactLayout; }
            set {
                if(compactLayout == value) return;
                compactLayout = value;
                UpdateCompactLayout();
            }
        }
        void UpdateCompactLayout() {
            btnNewLayoutControlItem.Visibility = compactLayout ? LayoutVisibility.Never : LayoutVisibility.Always;
        }
        #endregion
    }
}
