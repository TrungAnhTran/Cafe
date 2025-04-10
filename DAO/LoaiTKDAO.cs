using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LoaiTKDAO
    {
        ANHCF caffe=new ANHCF();
        private static LoaiTKDAO instance;
        public static LoaiTKDAO Instance
        {
            get
            {
                if(instance==null)
                    instance = new LoaiTKDAO();
                return instance;
            }
        }
        public List<LoaiTKDTO> LayDSLoaiTK()
        {
            var list=caffe.LoaiTKs.Where(p=>p.TrangThai.Value==true).ToList();
            return list.Select(P=> new LoaiTKDTO
            {
                idloaitk=P.IDLoaiTK,
                tenloaitk=P.TenLoaiTK,
                trangthai=P.TrangThai.Value
            }).ToList();
        }
        public bool ThemLoaiTk(LoaiTKDTO ltk)
        {
            try
            {
                LoaiTK them = new LoaiTK
                {
                    TenLoaiTK = ltk.tenloaitk,
                    TrangThai = ltk.trangthai
                };
                caffe.LoaiTKs.Add(them);
                caffe.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SuaLoaiTk(LoaiTKDTO ltk)
        {
            try
            {
                LoaiTK sua = caffe.LoaiTKs.SingleOrDefault(p => p.IDLoaiTK == ltk.idloaitk);
               
                 sua.TenLoaiTK = ltk.tenloaitk;
                
                if (caffe.SaveChanges() == 0) return false;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaLoaiTk(LoaiTKDTO ltk)
        {
            try
            {
                LoaiTK xoa = caffe.LoaiTKs.SingleOrDefault(p => p.IDLoaiTK == ltk.idloaitk);
                
                xoa.TrangThai = false;
                
                if (caffe.SaveChanges() == 0) return false;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool KiemTraTonTai(int id)
        {
            var kt = caffe.LoaiTKs.Join(caffe.TaiKhoans, c => c.IDLoaiTK, ct => ct.MaLoaiTK, (c, ct)
                => new { Loaitk = c, Taikhoan = ct }).Where(data => data.Loaitk.TrangThai.Value == true && data.Loaitk.IDLoaiTK == id)
                .Select(data => data.Loaitk).ToList();
            if(kt.Count>0)
            {
                return true;
            }
            return false;
        }

        public bool KiemTraTonTaiDataView(string tenltk)
        {
            var kt = caffe.LoaiTKs.Where(p => p.TenLoaiTK.Contains(tenltk) && p.TrangThai == true).ToList();
            //Contains thay thế cho %
            if (kt.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
