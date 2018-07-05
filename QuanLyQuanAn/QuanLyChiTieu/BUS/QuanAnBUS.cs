using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    class QuanAnBUS
    {
        QuanLyQuanAnRepository qlRepo;
        public QuanAnBUS(dbConnection conn)
        {
            qlRepo = new QuanLyQuanAnRepository(conn);
        }
        public void createConnect(dbConnection conn)
        {
            qlRepo = new QuanLyQuanAnRepository(conn);
        }

        public DataTable getAllRestaurant()
        {
            try
            {
                return qlRepo.findAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable addRestaurent(QuanAn qa)
        {
            try
            {
                qlRepo.saveOne(qa);
                return getAllRestaurant();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable updateRestaurent(QuanAn qa)
        {
            try
            {
                qlRepo.update(qa);
                
                return getAllRestaurant();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable deleteRestaurant(QuanAn qa)
        {
            try
            {
                qlRepo.delete(qa);
                return getAllRestaurant();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
