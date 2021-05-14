using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Ordinario.Entities;

namespace Ordinario
{
    public partial class FrmCoordinator : MetroFramework.Forms.MetroForm
    {
        public FrmCoordinator()
        {
            InitializeComponent();
        }

        private void FrmCoordinator_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                
                {
                    coordinatorBindingSource.DataSource = dataContext.Coaches.ToList();
                }

                pnlDatos.Enabled = false;

                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;

                if (coordinator != null && coordinator.Photo != null)
                {
                    pctPhoto.Image = Image.FromFile(coordinator.Photo);
                }
                else
                {
                    pctPhoto.Image = null;
                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.Photo != null)
            {
                pctPhoto.Image = Image.FromFile(coordinator.Photo);
            }
            else
            {
                pctPhoto.Image = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctPhoto.Image = Image.FromFile(ofd.FileName);

                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator ;
                    ;
                    if (coordinator != null)
                    {
                        coordinator.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            coordinatorBindingSource.Add(new Coordinator());
            coordinatorBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "quieres eliminar el coordinator?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                    {
                        if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                            dataContext.Set<Coordinator>().Attach(coordinator);



                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "coordinator eliminado");
                        coordinatorBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlDatos.Enabled = false;


                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            coordinatorBindingSource.ResetBindings(false);
            FrmCoordinator_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                if (coordinator != null)
                {
                    if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                        dataContext.Set<Coordinator>().Attach(coordinator);
                    if (coordinator.Id == 0)

                    {
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Added;

                    }
                    else
                    {
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Modified;
                    }
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "entrenador guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }
    }
}
