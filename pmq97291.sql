create database PhamMinhQuang97291
use PhamMinhQuang97291

create table ChucVu_2(
	MaChucVu nvarchar(3) primary key,
	TenChucVu nvarchar(30) not null unique,
	MucLuong float check(MucLuong >= 0) not null,
	PhuCap float check(PhuCap >= 0) not null
);
go

create table NhanVien_9(
	MaNhanVien nvarchar(5) primary key,
	HoTen nvarchar(50) not null,
	MaChucVu nvarchar(3) not null references ChucVu_2(MaChucVu),
	NgayVaoLam date not null
);
go

create table KhoHang_1(
	MaKhoHang nvarchar(3) primary key,
	TenKhoHang nvarchar(30) not null unique,
	DiaChi nvarchar(100) not null,
	MaNhanVienPhuTrach nvarchar(5) not null references NhanVien_9(MaNhanVien)
);


select * from ChucVu_2
select * from NhanVien_9
select * from KhoHang_1

create procedure ThemNhanVien
	@MaNhanVien nvarchar(5),
	@HoTen nvarchar(50),
	@MaChucVu nvarchar(3),
	@NgayVaoLam DATE
AS BEGIN
	DECLARE @Dem INT;
	DECLARE @Loi nvarchar(300);
	SET @Loi = ' ';

	set @Dem = (SELECT COUNT(*) FROM NhanVien_9 WHERE MaNhanVien = @MaNhanVien);
	if @Dem > 0
		set @Loi = N'Ma nhan vien da ton tai.'

	set @Dem = (SELECT COUNT(*) FROM ChucVu_2 WHERE MaChucVu = @MaChucVu);
	if @Dem = 0
		set @Loi = N'Ma chuc vu khong ton tai'

	if @NgayVaoLam > getdate()
		set @Loi = N'Ngay vao lam khong hop le'

	if @Loi = ' '
		insert into NhanVien_9 (MaNhanVien, HoTen, MaChucVu, NgayVaoLam)
		values (@MaNhanVien, @HoTen, @MaChucVu, @NgayVaoLam);
	else
		raiserror(@Loi, 16, 1);
END

EXEC ThemNhanVien
    @MaNhanVien = 'NV006',
    @HoTen = N'Nguyen Van A',
    @MaChucVu = 'CV1',
    @NgayVaoLam = '2023-12-01';

CREATE FUNCTION TimKiemKhoHang1
    (@KeyWord nvarchar(40))
RETURNS TABLE
AS RETURN 
    (SELECT MaKhoHang, TenKhoHang, MaNhanVienPhuTrach 
     FROM KhoHang_1
     INNER JOIN NhanVien_9 ON KhoHang_1.MaNhanVienPhuTrach = NhanVien_9.MaNhanVien
     WHERE MaKhoHang LIKE '%' + @KeyWord + '%'
        OR TenKhoHang LIKE '%' + @KeyWord + '%'
        OR MaNhanVienPhuTrach LIKE '%' + @KeyWord + '%'
    );

SELECT *
FROM TimKiemKhoHang1(N'C');


create procedure ThemChucVu
	@MaChucVu nvarchar(3), @TenChucVu nvarchar(30), @MucLuong float, @PhuCap float
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (select count(*) from ChucVu_2 where MaChucVu = @MaChucVu)
	if @Dem > 0
		set @Loi = N'Ma chuc vu da ton tai'

	set @Dem = (select count(*) from ChucVu_2 where TenChucVu = @TenChucVu)
	if @Dem > 0
		set @Loi = N'Ten chuc vu da ton tai'

	if @MucLuong < 0
		set @Loi = N'Khong tinh nhan luong ha'

	if @PhuCap < 0
		set @Loi = N'Che phu cap ha'

	if @Loi = ' '
		insert into ChucVu_2(MaChucVu, TenChucVu, MucLuong, PhuCap) values (@MaChucVu, @TenChucVu, @MucLuong, @PhuCap)
	else
		raiserror(@Loi, 16, 1)
end

drop procedure SuaChucVu

create procedure SuaChucVu
	@MaChucVu nvarchar(3), @TenChucVu nvarchar(30), @MucLuong float, @PhuCap float
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '
	
	set @Dem = (select count(*) from ChucVu_2 where MaChucVu = @MaChucVu)
	if @Dem = 0
		set @Loi = N'Ma chuc vu khong he ton tai'

	set @Dem = (select count(*) from ChucVu_2 where TenChucVu = @TenChucVu AND MaChucVu !=  @MaChucVu)
	if @Dem > 0
		set @Loi = N'Ten chuc vu nay da ton tai'
	
	if @MucLuong < 0 
		set @Loi = N'Che k nhan luong ha'

	if @PhuCap < 0
		set @Loi = N'Che phu cap ha'

	if @Loi = ' '
		 update ChucVu_2
		 set TenChucVu = @TenChucVu,
			MucLuong = @MucLuong,
			PhuCap = @PhuCap
		where MaChucVu = @MaChucVu
	else
		raiserror(@Loi, 16, 1)
end

create procedure XoaChucVu
	@MaChucVu nvarchar(3)
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (select count(*) from ChucVu_2 where MaChucVu = @MaChucVu)
	if @Dem = 0
		set @Loi = N'Ma chuc vu khong ton tai'

	set @Dem = (select count(*) from NhanVien_9 where MaChucVu = @MaChucVu)
	if @Dem > 0
		set @Loi = N'Khong the xoa do da ton tai o NhanVien'

	if @Loi = ' '
		delete from ChucVu_2
		where MaChucVu = @MaChucVu
	else 
		raiserror(@Loi, 16, 1)
end

select * from ChucVu_2

CREATE FUNCTION TimKiemChucVu
(
    @MaChucVu nvarchar(3),
    @TenChucVu nvarchar(30),
    @MucLuong float,
    @PhuCap float
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM ChucVu_2
    WHERE (@MaChucVu IS NULL OR MaChucVu = @MaChucVu)
        AND (@TenChucVu IS NULL OR TenChucVu LIKE '%' + @TenChucVu + '%')
        AND (@MucLuong IS NULL OR MucLuong = @MucLuong)
        AND (@PhuCap IS NULL OR PhuCap = @PhuCap)
)

drop function TimKiemChucVu
select * from TimKiemChucVu(NULL, 'Tester', NULL, NULL);
