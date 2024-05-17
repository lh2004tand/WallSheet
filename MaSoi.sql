CREATE DATABASE Masoi;
USE Masoi;

CREATE TABLE Dangnhap 
(
    id NVARCHAR(10),
    TenDangNhap NVARCHAR(20),
    matkhau NVARCHAR(20),
    CONSTRAINT pk_id PRIMARY KEY (id)
);
create table PhongCho
(
idPhong Nvarchar(10),
price money,
constraint pk_idphong primary key (idphong)

);
create table tinNhan
(
noidung nvarchar(1000),
idnguoigui int,
idnguoinhan int,
thoigian time,
idroomchat nvarchar(15)
constraint pk_idroomchat primary key(idroomchat)
);
create table hoso
(
Manguoichoi int,
avarta image,
trangthai char(5),
check (trangthai in ('on','offline')),
constraint pk_Manguoichoi primary key(manguoichoi)

);
