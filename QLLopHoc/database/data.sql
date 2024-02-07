use hybrid;
INSERT INTO nhomquyen(manhomquyen,ten) VALUES 
(1,'admin'),
(2,'user');

INSERT INTO taikhoan(mataikhoan,hoten,email,matkhau,sodienthoai,anhdaidien,manhomquyen,daxoa) VALUES
('6FCB6A47-75C2-425C-BBBD-FF7137A5FD54',N'Quan li 1','admin1.hybrid@gmail.com','admin','0939643659',null,1,0),
('17593A02-3763-4B70-9454-D71C3AF0BD19',N'Trần Vĩ Hào','tranvihao@gmail.com','123456789','0987318803',null,2,0),
('58824EDD-2CE6-46E8-97F3-8CA6970D8CBF',N'Nguyễn Huy Hoàng','nguyenhuyhoang@gmail.com','123456789','0961621298',null,2,0),
('1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9',N'Mạch Hạo Tuấn','machhaotuan@gmail.com','123456789','0993195921',null,2,0),
('6B157E9A-4F74-4EE8-A893-06BC950F4272',N'Lâm Tuấn Kiệt','lamtuankiet@gmail.com','123456789','0992820560',null,2,0);

INSERT INTO lophoc(malophoc,ten,mota,daxoa,magiangvien) VALUES
    ('2A4A1B9E-4263-4CB0-9D2A-51137915F600',N'Quản lý nhân sự', N'Môn học về quản lý nhân sự', 1, '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
    ('7CF1DB66-9EEE-4039-9D3C-633E5B2C801A',N'Khoa học máy tính', N'Môn học về khoa học máy tính', 1, '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
    ('A3F6E0BC-0D60-4E99-89DF-6C2F8435717F',N'Quản trị kinh doanh', N'Môn học về quản trị kinh doanh', 1, '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4',N'Vật lý lý thuyết', N'Môn học về vật lý lý thuyết', 1, '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('A8AD4D61-6B4B-4684-A591-685DB2058B9D',N'Lập trình C#', N'Môn học về lập trình C#', 1, '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('FD2970E0-E379-48D1-90AF-DE80E5AF3A6C',N'Marketing', N'Môn học về marketing', 1, '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('A816A89A-EDEE-4FCE-B917-F800F2CE2E8D',N'Khoa học dữ liệu', N'Môn học về khoa học dữ liệu', 1, '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('5D39847C-BFA7-4D67-8EC4-3E404D85CBB2',N'Lập trình Java', N'Môn học về lập trình Java', 1, '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF',N'Kỹ thuật lập trình', N'Môn học về kỹ thuật lập trình', 1, '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52',N'Thiết kế đồ họa', N'Môn học về thiết kế đồ họa', 1, '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF');


INSERT INTO chuong(machuong,malophoc, ten, thoigiantao)
VALUES
--kĩ thuật lập trình
    ('90E1FFC6-3EFF-4AB2-B083-9761C53BA80D','3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', N'Chương 1: Cơ bản về lập trình', GETDATE()),
    ('BF51761B-F241-4B57-84DB-FF68F7698798','3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', N'Chương 2: Cấu trúc điều khiển', GETDATE()),
    ('CC2F76B5-6A0D-4E1D-876B-4614B5A9D37E','3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', N'Chương 3: Hàm và thư viện', GETDATE()),
    ('0CFF6362-E165-4819-AF95-9591D6C9F043','3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', N'Chương 4: Mảng và chuỗi', GETDATE()),
    ('106B0ADC-B6D7-4FA5-B567-00FE40CB40E1','3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', N'Chương 5: OOP (Lập trình hướng đối tượng)', GETDATE()),
-- lập trình java
	('FCBAB77B-59B4-40D9-8D6A-CA6E7F6F4FB3','5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', N'Chương 1: Giới thiệu về Java', GETDATE()),
    ('B759DDB5-599B-46A6-B040-C2554E308100','5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', N'Chương 2: Cú pháp cơ bản của Java', GETDATE()),
    ('E8E32C99-2D66-426E-9C8E-5E03B6AEAEC7','5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', N'Chương 3: Lập trình hướng đối tượng trong Java', GETDATE()),
    ('5B664759-A5FC-46E5-A348-210F1A47A712','5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', N'Chương 4: Xử lý ngoại lệ trong Java', GETDATE()),
    ('02B7BF16-FC5F-4F1D-B4F3-481ABAEF2D3B','5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', N'Chương 5: Ứng dụng thực tế với Java', GETDATE()),
-- quản lý nhân sự
	('75ABB487-2315-4BC9-8BDB-8071F2047013','2A4A1B9E-4263-4CB0-9D2A-51137915F600', N'Chương 1: Giới thiệu về quản lý nhân sự', GETDATE()),
    ('6DB15BE0-7884-4654-AAC8-6704B63437DA','2A4A1B9E-4263-4CB0-9D2A-51137915F600', N'Chương 2: Tuyển dụng và tuyển chọn nhân sự', GETDATE()),
    ('8A4933B9-F7C5-4030-BF4F-8A874D665D17','2A4A1B9E-4263-4CB0-9D2A-51137915F600', N'Chương 3: Đào tạo và phát triển nhân sự', GETDATE()),
    ('F4D79A22-3106-4AF1-9C69-EB05DD9C11D4','2A4A1B9E-4263-4CB0-9D2A-51137915F600', N'Chương 4: Quản lý hiệu suất và đánh giá nhân sự', GETDATE()),
    ('FAA8061C-2642-40AC-A002-CD772F59DD06','2A4A1B9E-4263-4CB0-9D2A-51137915F600', N'Chương 5: Quản lý xung đột và giải quyết tranh chấp', GETDATE()),
    ('7F8BE279-57E8-4EDF-9C3D-5922F24CA02D','2A4A1B9E-4263-4CB0-9D2A-51137915F600', N'Chương 6: Chiến lược quản lý nhân sự', GETDATE()),
-- khoa học máy tính
	('7D05DBEF-094D-4FF8-919C-A21E2E73392A','7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', N'Chương 1: Giới thiệu về khoa học máy tính', GETDATE()),
    ('9CE0A8E3-142C-498F-BAFF-565F33C6CF4E','7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', N'Chương 2: Cấu trúc dữ liệu và giải thuật', GETDATE()),
    ('2F5AB3A7-E6AE-41C7-8211-22460F7345DB','7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', N'Chương 3: Lập trình và thuật toán', GETDATE()),
    ('4695FA07-DCD3-4B31-908A-67C6760DB8A4','7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', N'Chương 4: Mạng máy tính và internet', GETDATE()),
    ('CCCBC5D1-84A9-4D6C-8973-CBC6E462E7E2','7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', N'Chương 5: Trí tuệ nhân tạo và học máy', GETDATE()),
-- quản trị kinh doanh
	('FFDFB03F-70A9-4311-9AD4-0B5C295B3276','A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', N'Chương 1: Giới thiệu về quản trị kinh doanh', GETDATE()),
    ('F8AD623E-0C71-4954-B30D-20DF2016AADC','A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', N'Chương 2: Lập kế hoạch và chiến lược kinh doanh', GETDATE()),
    ('4C9F9896-6670-410C-AC23-7F8E5E942091','A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', N'Chương 3: Quản lý tài chính và tài sản', GETDATE()),
    ('C00C1128-81F9-4444-992C-1703DD3D1B52','A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', N'Chương 4: Quản lý nhân sự và tài nguyên loại hình', GETDATE()),
    ('7A85DBB5-3BD1-415B-8BBF-1B6057A5964B','A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', N'Chương 5: Tiếp thị và quản lý sản phẩm', GETDATE()),
-- thiết kế đồ họa
    ('89AB4A74-BADC-4B60-AE27-A0808EDEF353','70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', N'Chương 3: Màu sắc và cân bằng trong thiết kế', GETDATE()),
	('9B60C953-C291-4028-B092-79600EA713A2','70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', N'Chương 1: Giới thiệu về thiết kế đồ họa', GETDATE()),
    ('663E6EED-A0F8-4560-A1C4-CAF77F2AD8ED','70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', N'Chương 2: Cơ bản về công cụ thiết kế đồ họa', GETDATE()),
    ('FCB444B2-7E74-4BD1-A057-D2CCD74A1C22','70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', N'Chương 4: Thực hành thiết kế đồ họa', GETDATE()),
    ('36E1D8AD-B2B7-4E30-B3DA-DE82952944CA','70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', N'Chương 5: Tạo hình ảnh và biểu đồ', GETDATE()),
-- khoa học dữ liệu
	('190D8526-3A71-4EA5-BB97-5124F64F7483','A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', N'Chương 1: Giới thiệu về khoa học dữ liệu', GETDATE()),
    ('AF1953A7-F70B-4640-8AB0-E661757E5C1A','A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', N'Chương 2: Xử lý và phân tích dữ liệu', GETDATE()),
    ('61734ED5-972A-4B86-B19A-AE9EDAB872C1','A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', N'Chương 3: Machine Learning và học máy', GETDATE()),
    ('4859329D-0D35-442D-8AAC-0EA1AFCC2F54','A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', N'Chương 4: Visualizations và trình bày dữ liệu', GETDATE()),
    ('DD3E506A-0D8F-4E23-A9D1-B5E3D0ED6FD3','A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', N'Chương 5: Ứng dụng thực tế của khoa học dữ liệu', GETDATE()),
-- marketing
	 ('E6FE44C5-1C0D-4398-A3AC-62257F9F1E61', 'FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', N'Chương 1: Giới thiệu về marketing', GETDATE()),
    ('D3602B84-0B4E-4F34-9B50-ACECCF3451FF', 'FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', N'Chương 2: Nghiên cứu thị trường và phân tích khách hàng', GETDATE()),
    ('84A4B723-C50D-4A69-A33D-429E1F143F5C', 'FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', N'Chương 3: Chiến lược tiếp thị và quảng cáo', GETDATE()),
    ('E681AEF3-08B5-4639-A413-18A14AF9B631', 'FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', N'Chương 4: Phân phối và giá cả trong marketing', GETDATE()),
    ('0315D9BC-B5B0-443D-BD61-B8A2FAF0246C', 'FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', N'Chương 5: Quản lý thương hiệu và quan hệ khách hàng', GETDATE()),
-- lập trình c#
('55EFC63E-39B6-4A7D-943B-6E5C574548CA', 'A8AD4D61-6B4B-4684-A591-685DB2058B9D', N'Chương 1: Giới thiệu về lập trình C#', GETDATE()),
    ('B0D183FD-8F64-4591-908C-F7D3FA56E1FA', 'A8AD4D61-6B4B-4684-A591-685DB2058B9D', N'Chương 2: Cú pháp cơ bản và biến trong C#', GETDATE()),
    ('DDEB0E8E-A81D-453A-99A5-734035921C3F', 'A8AD4D61-6B4B-4684-A591-685DB2058B9D', N'Chương 3: Lập trình hướng đối tượng trong C#', GETDATE()),
    ('25D57EF6-C76C-4659-A09C-0BA40C0EB511', 'A8AD4D61-6B4B-4684-A591-685DB2058B9D', N'Chương 4: Xử lý ngoại lệ và lỗi trong C#', GETDATE()),
    ('6ED16D56-E334-4D12-A157-09B086B861B5', 'A8AD4D61-6B4B-4684-A591-685DB2058B9D', N'Chương 5: Ứng dụng thực tế với lập trình C#', GETDATE()),
-- vật lý lý thuyết
 ('F8DF003B-6D7B-4333-8A3A-157D71C081A5', '480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', N'Chương 1: Động học lý thuyết', GETDATE()),
    ('3E84D2D6-24D6-4040-A126-063DACA6FB36', '480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', N'Chương 2: Vật lý hạt nhân', GETDATE()),
    ('FFEDACCC-7BBC-421C-A5D7-92BF04399445', '480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', N'Chương 3: Cơ học lý thuyết', GETDATE()),
    ('C5A1F0E2-1B92-4E6C-B22F-BB90AFA01940', '480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', N'Chương 4: Vật lý lý thuyết đương đại', GETDATE()),
    ('DF258757-02E0-478F-BA6A-93BD70EC02FA', '480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', N'Chương 5: Lý thuyết trường và thời gian', GETDATE());

	INSERT INTO thamgialophoc (malophoc, mataikhoan) VALUES
-- kĩ thuật lập trình
    ('3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('3CA75F6C-5EF9-46A2-9C26-324EC4E81ABF', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- lập trình java
    ('5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('5D39847C-BFA7-4D67-8EC4-3E404D85CBB2', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- quản lý nhân sự
    ('2A4A1B9E-4263-4CB0-9D2A-51137915F600', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('2A4A1B9E-4263-4CB0-9D2A-51137915F600', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('2A4A1B9E-4263-4CB0-9D2A-51137915F600', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('2A4A1B9E-4263-4CB0-9D2A-51137915F600', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
-- khoa học máy tính
    ('7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('7CF1DB66-9EEE-4039-9D3C-633E5B2C801A', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
-- lập trình c#
    ('A8AD4D61-6B4B-4684-A591-685DB2058B9D', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('A8AD4D61-6B4B-4684-A591-685DB2058B9D', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('A8AD4D61-6B4B-4684-A591-685DB2058B9D', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('A8AD4D61-6B4B-4684-A591-685DB2058B9D', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- quản trị kinh doanh
    ('A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('A3F6E0BC-0D60-4E99-89DF-6C2F8435717F', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- thiết kế đồ họa
    ('70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('70A5D232-E4C3-42AA-B4EC-BCA4CE1FEC52', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- marketing 
    ('FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('FD2970E0-E379-48D1-90AF-DE80E5AF3A6C', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- Khoa học dữ liệu
    ('A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', '58824EDD-2CE6-46E8-97F3-8CA6970D8CBF'),
    ('A816A89A-EDEE-4FCE-B917-F800F2CE2E8D', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54'),
-- Vật lý lý thuyết
    ('480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', '6B157E9A-4F74-4EE8-A893-06BC950F4272'),
    ('480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', '1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9'),
    ('480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', '17593A02-3763-4B70-9454-D71C3AF0BD19'),
    ('480EE4E4-ACEF-4B0D-97DB-FA644E0AD9D4', '6FCB6A47-75C2-425C-BBBD-FF7137A5FD54');

INSERT INTO baitap(machuong,tieude,noidungbaitap,thoigiantao,thoihan) VALUES
-- lập trình java
	('FCBAB77B-59B4-40D9-8D6A-CA6E7F6F4FB3', N'Bài tập Java 1', N'Viết một chương trình Java để tính tổng hai số.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('B759DDB5-599B-46A6-B040-C2554E308100', N'Bài tập Java 2', N'Viết một ứng dụng Java để quản lý danh bạ.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E8E32C99-2D66-426E-9C8E-5E03B6AEAEC7', N'Bài tập Java 3', N'Xây dựng một trò chơi sử dụng Java Swing.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('5B664759-A5FC-46E5-A348-210F1A47A712', N'Bài tập Java 4', N'Viết một ứng dụng Java cho quản lý thư viện.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('02B7BF16-FC5F-4F1D-B4F3-481ABAEF2D3B', N'Bài tập Java 5', N'Xây dựng một ứng dụng đồ họa Java.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FCBAB77B-59B4-40D9-8D6A-CA6E7F6F4FB3', N'Bài tập Java 6', N'Viết một ứng dụng Java cho quản lý sản phẩm.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('B759DDB5-599B-46A6-B040-C2554E308100', N'Bài tập Java 7', N'Xây dựng một ứng dụng Java dự đoán thời tiết.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E8E32C99-2D66-426E-9C8E-5E03B6AEAEC7', N'Bài tập Java 8', N'Viết một ứng dụng Java cho quản lý nhân viên.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('5B664759-A5FC-46E5-A348-210F1A47A712', N'Bài tập Java 9', N'Xây dựng một ứng dụng Java cho quản lý đơn hàng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('02B7BF16-FC5F-4F1D-B4F3-481ABAEF2D3B', N'Bài tập Java 10', N'Viết một ứng dụng Java cho quản lý học sinh.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
--  kĩ thuật lập trình
	('90E1FFC6-3EFF-4AB2-B083-9761C53BA80D', N'Quản lý danh bạ: Xây dựng ứng dụng quản lý danh bạ.', 'Description for Quản lý danh bạ.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('90E1FFC6-3EFF-4AB2-B083-9761C53BA80D', N'Sắp xếp và Tìm kiếm: Thực hiện sắp xếp và tìm kiếm mảng số nguyên.', 'Description for Sắp xếp và Tìm kiếm.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('BF51761B-F241-4B57-84DB-FF68F7698798', N'Xử lý chuỗi: Đảo ngược chuỗi, tách từ trong câu, kiểm tra Palindrome.', 'Description for Xử lý chuỗi.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('BF51761B-F241-4B57-84DB-FF68F7698798', N'Quản lý Sinh viên: Hệ thống quản lý thông tin sinh viên.', 'Description for Quản lý Sinh viên.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('CC2F76B5-6A0D-4E1D-876B-4614B5A9D37E', N'Đệ quy: Tính số Fibonacci hoặc tìm kiếm đệ quy trong cây nhị phân.', 'Description for Đệ quy.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('CC2F76B5-6A0D-4E1D-876B-4614B5A9D37E', N'Đối tượng và Lập trình hướng đối tượng: Tạo lớp đối tượng.', 'Description for Đối tượng và Lập trình hướng đối tượng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('0CFF6362-E165-4819-AF95-9591D6C9F043', N'Xử lý File: Đọc và ghi dữ liệu vào tệp tin.', 'Description for Xử lý File.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('0CFF6362-E165-4819-AF95-9591D6C9F043', N'Xử lý Exception: Xử lý ngoại lệ và lỗi.', 'Description for Xử lý Exception.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('106B0ADC-B6D7-4FA5-B567-00FE40CB40E1', N'Mạng: Ứng dụng mạng sử dụng giao thức TCP hoặc UDP.', 'Description for Mạng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('106B0ADC-B6D7-4FA5-B567-00FE40CB40E1', N'Giao diện người dùng: Xây dựng ứng dụng GUI với Swing hoặc Tkinter.', 'Description for Giao diện người dùng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- quản lý nhân sự
    ('75ABB487-2315-4BC9-8BDB-8071F2047013', N'Phân tích cơ cấu tổ chức và vai trò của từng bộ phận.', N'Bài tập về phân tích cơ cấu tổ chức và vai trò của từng bộ phận.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('6DB15BE0-7884-4654-AAC8-6704B63437DA', N'Quản lý hồ sơ nhân viên và lịch sử làm việc.', N'Bài tập về quản lý hồ sơ nhân viên và lịch sử làm việc.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('8A4933B9-F7C5-4030-BF4F-8A874D665D17', N'Thiết kế hệ thống đánh giá hiệu suất nhân viên.', N'Bài tập về thiết kế hệ thống đánh giá hiệu suất nhân viên.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('F4D79A22-3106-4AF1-9C69-EB05DD9C11D4', N'Tạo kế hoạch đào tạo và phát triển cá nhân.', N'Bài tập về tạo kế hoạch đào tạo và phát triển cá nhân.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FAA8061C-2642-40AC-A002-CD772F59DD06', N'Xây dựng chính sách và quy trình HR.', N'Bài tập về xây dựng chính sách và quy trình HR.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('7F8BE279-57E8-4EDF-9C3D-5922F24CA02D', N'Tư vấn về luật lao động và quy định công ty.', N'Bài tập về tư vấn về luật lao động và quy định công ty.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('75ABB487-2315-4BC9-8BDB-8071F2047013', N'Quản lý tuyển dụng và tuyển dụng nhân viên mới.', N'Bài tập về quản lý tuyển dụng và tuyển dụng nhân viên mới.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('6DB15BE0-7884-4654-AAC8-6704B63437DA', N'Xây dựng chính sách và quy trình tuyển dụng.', N'Bài tập về xây dựng chính sách và quy trình tuyển dụng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('8A4933B9-F7C5-4030-BF4F-8A874D665D17', N'Phân tích nhu cầu công việc và tạo mô tả công việc.', N'Bài tập về phân tích nhu cầu công việc và tạo mô tả công việc.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('F4D79A22-3106-4AF1-9C69-EB05DD9C11D4', N'Tạo kế hoạch đào tạo và phát triển nhân viên.', N'Bài tập về tạo kế hoạch đào tạo và phát triển nhân viên.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- khoa học máy tính
	('7D05DBEF-094D-4FF8-919C-A21E2E73392A', N'Thiết kế và phát triển ứng dụng web đơn giản.', N'Bài tập về thiết kế và phát triển ứng dụng web đơn giản.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('9CE0A8E3-142C-498F-BAFF-565F33C6CF4E', N'Xây dựng hệ thống quản lý cơ sở dữ liệu.', N'Bài tập về xây dựng hệ thống quản lý cơ sở dữ liệu.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('2F5AB3A7-E6AE-41C7-8211-22460F7345DB', N'Lập trình ứng dụng di động cho nền tảng Android.', N'Bài tập về lập trình ứng dụng di động cho nền tảng Android.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('4695FA07-DCD3-4B31-908A-67C6760DB8A4', N'Phân tích và tối ưu hóa hiệu năng của ứng dụng.', N'Bài tập về phân tích và tối ưu hóa hiệu năng của ứng dụng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('CCCBC5D1-84A9-4D6C-8973-CBC6E462E7E2', N'Lập trình ứng dụng máy tính đám mây (cloud computing).', N'Bài tập về lập trình ứng dụng máy tính đám mây (cloud computing).', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('7D05DBEF-094D-4FF8-919C-A21E2E73392A', N'Phát triển trò chơi máy tính đa nền tảng.', N'Bài tập về phát triển trò chơi máy tính đa nền tảng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('9CE0A8E3-142C-498F-BAFF-565F33C6CF4E', N'Tạo phần mềm bảo mật và kiểm tra lỗ hổng bảo mật.', N'Bài tập về tạo phần mềm bảo mật và kiểm tra lỗ hổng bảo mật.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('2F5AB3A7-E6AE-41C7-8211-22460F7345DB', N'Xây dựng hệ thống thông tin đối tượng (IoT).', N'Bài tập về xây dựng hệ thống thông tin đối tượng (IoT).', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('4695FA07-DCD3-4B31-908A-67C6760DB8A4', N'Phân tích dữ liệu và khai thác thông tin từ dữ liệu lớn (Big Data).', N'Bài tập về phân tích dữ liệu và khai thác thông tin từ dữ liệu lớn (Big Data).', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('CCCBC5D1-84A9-4D6C-8973-CBC6E462E7E2', N'Nghiên cứu và phát triển trí tuệ nhân tạo (AI).', N'Bài tập về nghiên cứu và phát triển trí tuệ nhân tạo (AI).', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- lập trình c#
	('55EFC63E-39B6-4A7D-943B-6E5C574548CA', N'Viết chương trình C# để tính tổng hai số.', N'Bài tập về viết chương trình C# để tính tổng hai số.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('B0D183FD-8F64-4591-908C-F7D3FA56E1FA', N'Xây dựng ứng dụng quản lý danh bạ sử dụng C#.', N'Bài tập về xây dựng ứng dụng quản lý danh bạ sử dụng C#.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('DDEB0E8E-A81D-453A-99A5-734035921C3F', N'Lập trình ứng dụng C# sử dụng Windows Forms.', N'Bài tập về lập trình ứng dụng C# sử dụng Windows Forms.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('25D57EF6-C76C-4659-A09C-0BA40C0EB511', N'Phát triển ứng dụng C# cho quản lý thư viện.', N'Bài tập về phát triển ứng dụng C# cho quản lý thư viện.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('6ED16D56-E334-4D12-A157-09B086B861B5', N'Xây dựng ứng dụng đồ họa C#.', N'Bài tập về xây dựng ứng dụng đồ họa C#.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('55EFC63E-39B6-4A7D-943B-6E5C574548CA', N'Viết ứng dụng C# cho quản lý sản phẩm.', N'Bài tập về viết ứng dụng C# cho quản lý sản phẩm.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('B0D183FD-8F64-4591-908C-F7D3FA56E1FA', N'Tạo ứng dụng C# dự đoán thời tiết.', N'Bài tập về tạo ứng dụng C# dự đoán thời tiết.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('DDEB0E8E-A81D-453A-99A5-734035921C3F', N'Phát triển ứng dụng C# quản lý nhân viên.', N'Bài tập về phát triển ứng dụng C# quản lý nhân viên.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('25D57EF6-C76C-4659-A09C-0BA40C0EB511', N'Xây dựng ứng dụng C# cho quản lý đơn hàng.', N'Bài tập về xây dựng ứng dụng C# cho quản lý đơn hàng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('6ED16D56-E334-4D12-A157-09B086B861B5', N'Viết ứng dụng C# cho quản lý học sinh.', N'Bài tập về viết ứng dụng C# cho quản lý học sinh.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- quản trị kinh doanh
	('FFDFB03F-70A9-4311-9AD4-0B5C295B3276', N'Phân tích tình hình thị trường và xác định cơ hội kinh doanh.', N'Bài tập về phân tích tình hình thị trường và xác định cơ hội kinh doanh.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('F8AD623E-0C71-4954-B30D-20DF2016AADC', N'Lập kế hoạch kinh doanh cho một doanh nghiệp mới.', N'Bài tập về lập kế hoạch kinh doanh cho doanh nghiệp mới.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('4C9F9896-6670-410C-AC23-7F8E5E942091', N'Xây dựng chiến lược tiếp thị và quảng cáo sản phẩm.', N'Bài tập về xây dựng chiến lược tiếp thị và quảng cáo sản phẩm.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('C00C1128-81F9-4444-992C-1703DD3D1B52', N'Phân tích tài chính và tạo ngân sách doanh nghiệp.', N'Bài tập về phân tích tài chính và tạo ngân sách doanh nghiệp.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('7A85DBB5-3BD1-415B-8BBF-1B6057A5964B', N'Quản lý và phát triển nhân sự trong tổ chức.', N'Bài tập về quản lý và phát triển nhân sự trong tổ chức.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FFDFB03F-70A9-4311-9AD4-0B5C295B3276', N'Nghiên cứu và phát triển chiến lược cạnh tranh.', N'Bài tập về nghiên cứu và phát triển chiến lược cạnh tranh.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('F8AD623E-0C71-4954-B30D-20DF2016AADC', N'Xây dựng hệ thống quản lý chuỗi cung ứng.', N'Bài tập về xây dựng hệ thống quản lý chuỗi cung ứng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('4C9F9896-6670-410C-AC23-7F8E5E942091', N'Tối ưu hóa quy trình sản xuất và phân phối.', N'Bài tập về tối ưu hóa quy trình sản xuất và phân phối.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('C00C1128-81F9-4444-992C-1703DD3D1B52', N'Quản lý rủi ro và chiến lược bảo vệ doanh nghiệp.', N'Bài tập về quản lý rủi ro và chiến lược bảo vệ doanh nghiệp.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('7A85DBB5-3BD1-415B-8BBF-1B6057A5964B', N'Phát triển chiến lược mở rộng hoặc sáp nhập và sáp nhập.', N'Bài tập về phát triển chiến lược mở rộng hoặc sáp nhập và sáp nhập.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- thiết kế đồ họa
	('89AB4A74-BADC-4B60-AE27-A0808EDEF353', N'Thiết kế biểu ngữ cho một sự kiện hoặc doanh nghiệp cụ thể.', N'Bài tập về thiết kế biểu ngữ cho sự kiện hoặc doanh nghiệp.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('9B60C953-C291-4028-B092-79600EA713A2', N'Tạo một poster quảng cáo cho sản phẩm hoặc dịch vụ.', N'Bài tập về tạo poster quảng cáo.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('663E6EED-A0F8-4560-A1C4-CAF77F2AD8ED', N'Thiết kế một logo cho một thương hiệu mới.', N'Bài tập về thiết kế logo cho thương hiệu mới.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FCB444B2-7E74-4BD1-A057-D2CCD74A1C22', N'Tạo một giao diện người dùng cho ứng dụng di động hoặc trang web.', N'Bài tập về thiết kế giao diện người dùng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('36E1D8AD-B2B7-4E30-B3DA-DE82952944CA', N'Tạo một bộ hình ảnh và màu sắc cho một dự án thương hiệu.', N'Bài tập về tạo bộ hình ảnh và màu sắc cho dự án thương hiệu.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('89AB4A74-BADC-4B60-AE27-A0808EDEF353', N'Thiết kế một bản sách điện tử hoặc bìa cho sách in.', N'Bài tập về thiết kế sách điện tử hoặc bìa cho sách in.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('9B60C953-C291-4028-B092-79600EA713A2', N'Tạo một gói thiết kế cho sản phẩm đóng gói.', N'Bài tập về tạo gói thiết kế cho sản phẩm đóng gói.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('663E6EED-A0F8-4560-A1C4-CAF77F2AD8ED', N'Tạo một hình minh họa cho một bài viết trực tuyến hoặc bản in.', N'Bài tập về tạo hình minh họa cho bài viết trực tuyến hoặc bản in.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FCB444B2-7E74-4BD1-A057-D2CCD74A1C22', N'Thiết kế một hộp thư rao bán hoặc thiệp mời.', N'Bài tập về thiết kế hộp thư rao bán hoặc thiệp mời.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('36E1D8AD-B2B7-4E30-B3DA-DE82952944CA', N'Tạo một ảnh nghệ thuật hoặc tranh sáng tạo.', N'Bài tập về tạo ảnh nghệ thuật hoặc tranh sáng tạo.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- marketing 
	('E6FE44C5-1C0D-4398-A3AC-62257F9F1E61', N'Tạo kế hoạch tiếp thị cho sản phẩm mới', N'Phân tích thị trường và xây dựng kế hoạch tiếp thị cho một sản phẩm hoặc dịch vụ mới.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('D3602B84-0B4E-4F34-9B50-ACECCF3451FF', N'Tạo chiến dịch quảng cáo trên mạng xã hội', N'Lập kế hoạch và triển khai chiến dịch quảng cáo trên các mạng xã hội.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('84A4B723-C50D-4A69-A33D-429E1F143F5C', N'Tạo kế hoạch tiếp thị nội dung', N'Phát triển kế hoạch tiếp thị nội dung cho việc tạo và chia sẻ nội dung giá trị.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E681AEF3-08B5-4639-A413-18A14AF9B631', N'Tạo chiến dịch email marketing', N'Thiết kế và triển khai chiến dịch email marketing để tương tác với khách hàng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('0315D9BC-B5B0-443D-BD61-B8A2FAF0246C', N'Tạo chiến dịch tiếp thị truyền hình', N'Lập kế hoạch và triển khai chiến dịch tiếp thị truyền hình hoặc video.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E6FE44C5-1C0D-4398-A3AC-62257F9F1E61', N'Tạo chiến dịch tiếp thị nội dung video', N'Lập kế hoạch và tạo nội dung video cho chiến dịch tiếp thị.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('D3602B84-0B4E-4F34-9B50-ACECCF3451FF', N'Tạo chiến dịch tiếp thị trực tiếp', N'Lập kế hoạch và triển khai chiến dịch tiếp thị trực tiếp đối với khách hàng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('84A4B723-C50D-4A69-A33D-429E1F143F5C', N'Tạo chiến dịch tiếp thị tương tác', N'Lập kế hoạch và thực hiện chiến dịch tiếp thị tương tác để tạo sự tham gia của khách hàng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E681AEF3-08B5-4639-A413-18A14AF9B631', N'Tạo chiến dịch quảng cáo truyền hình', N'Lập kế hoạch và triển khai chiến dịch quảng cáo truyền hình hoặc tương tác.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('0315D9BC-B5B0-443D-BD61-B8A2FAF0246C', N'Tạo chiến dịch quảng cáo ngoại trời', N'Lập kế hoạch và thực hiện chiến dịch quảng cáo ngoại trời hoặc quảng cáo dưới trời.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),

-- Khoa học dữ liệu
	('190D8526-3A71-4EA5-BB97-5124F64F7483', N'Phân tích tập dữ liệu Titanic', N'Dự đoán sống/chết của hành khách.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('AF1953A7-F70B-4640-8AB0-E661757E5C1A', N'Xây dựng mô hình phân loại', N'Dự đoán giá nhà dựa trên thông tin bất động sản.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('61734ED5-972A-4B86-B19A-AE9EDAB872C1', N'Sử dụng kỹ thuật trích xuất thông tin từ văn bản', N'Phân loại tin tức hoặc bài viết vào các chủ đề khác nhau.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('4859329D-0D35-442D-8AAC-0EA1AFCC2F54', N'Tạo bản đồ dữ liệu địa lý', N'Phân tích vị trí địa lý cho dự án liên quan đến vị trí.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('DD3E506A-0D8F-4E23-A9D1-B5E3D0ED6FD3', N'Xây dựng hệ thống khuyến nghị sản phẩm', N'Dựa trên hành vi trước đó của người dùng.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E6FE44C5-1C0D-4398-A3AC-62257F9F1E61', N'Sử dụng kỹ thuật khai phá dữ liệu', N'Tìm ra các mẫu và thông tin thú vị từ tập dữ liệu lớn.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('D3602B84-0B4E-4F34-9B50-ACECCF3451FF', N'Phân tích dữ liệu về tiêu dùng', N'Tạo chiến dịch tiếp thị hiệu quả hơn cho công ty.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('84A4B723-C50D-4A69-A33D-429E1F143F5C', N'Xây dựng hệ thống dự đoán thời tiết', N'Dựa trên dữ liệu thời tiết lịch sử.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('E681AEF3-08B5-4639-A413-18A14AF9B631', N'Sử dụng dữ liệu y tế', N'Dự đoán nguy cơ mắc bệnh dựa trên yếu tố cá nhân.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('0315D9BC-B5B0-443D-BD61-B8A2FAF0246C', N'Tạo mô hình dự đoán doanh số bán hàng', N'Dựa trên dữ liệu lịch sử và biến đổi mùa.', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
-- Vật lý lý thuyết
	('F8DF003B-6D7B-4333-8A3A-157D71C081A5', N'Lý thuyết tương đối của Einstein và hiệu ứng động lượng.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('3E84D2D6-24D6-4040-A126-063DACA6FB36', N'Phân tích sóng cơ học lượng tử cho các hạt như điện tử và photon.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FFEDACCC-7BBC-421C-A5D7-92BF04399445', N'Tính toán và dự đoán định luật Coulomb trong điện động lực học.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('C5A1F0E2-1B92-4E6C-B22F-BB90AFA01940', N'Nghiên cứu các nguyên tố và cấu trúc nguyên tử dựa trên lý thuyết nguyên tử.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('DF258757-02E0-478F-BA6A-93BD70EC02FA', N'Nghiên cứu sự biến đổi của vật chất dưới áp lực và nhiệt độ cực thấp.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('F8DF003B-6D7B-4333-8A3A-157D71C081A5', N'Điều tra các tính chất và ứng dụng của tinh thể học lý thuyết.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('3E84D2D6-24D6-4040-A126-063DACA6FB36', N'Xem xét hiệu ứng ánh sáng và tính chất của sóng điện từ trong vật lý lý thuyết.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('C5A1F0E2-1B92-4E6C-B22F-BB90AFA01940', N'Nghiên cứu cơ học lý thuyết của dòng điện và từ trường.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('DF258757-02E0-478F-BA6A-93BD70EC02FA', N'Điều tra tính chất của các loại bức xạ, chẳng hạn như bức xạ gamma và tia X.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) ),
	('FFEDACCC-7BBC-421C-A5D7-92BF04399445', N'Phân tích vật lý lý thuyết của các hiện tượng về nhiệt độ và áp suất trong chất lỏng và khí.', N'', GETDATE(), DATEADD(YEAR, 1, GETDATE()) );

INSERT INTO cauhoi(macauhoi, mataikhoan, noidung,daxoa) VALUES
-- quản trị kinh doanh
('0BFD6940-8502-4378-B8BA-F6CE8B564C44','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Nguyên tắc SWOT trong quản trị kinh doanh liên quan đến điều gì?', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7C','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Đâu là một ví dụ về một phần tử của mô hình PESTEL (hoặc PESTLE) trong phân tích môi trường kinh doanh?', 0),
('813A6E29-E967-444C-915F-8246E4E09CFA','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Thế nào là mục tiêu thông tin (SMART) trong quản trị kinh doanh?', 0),
('E357024C-770F-482F-927F-75279D7789C9','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Hệ thống ERP (Enterprise Resource Planning) trong quản trị kinh doanh được sử dụng để làm gì?', 0),
('ADDB928B-91E6-4286-800A-0F6484BBFDAC','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Đâu là một trong những nguyên tắc quan trọng của quản trị dự án trong quản trị kinh doanh?', 0),
-- marketing
('8682BF93-3932-4FE4-BFCC-E69DDC5DBDA4','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Phân đoạn thị trường là gì trong lĩnh vực tiếp thị?', 0),
('91A43CA5-A4D5-4019-B793-AEAB9F5A7253','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Cơ hội tiếp thị qua mạng xã hội thường được thực hiện trên nền tảng nào sau đây?', 0),
('9C0064AC-D17C-4591-A207-8A9B73332258','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Trong chiến lược tiếp thị, thuật ngữ "4P" thường đề cập đến những yếu tố nào?', 0),
('BD830252-CAE4-472D-9CB3-2E25D147EF36','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Khái niệm "hệ thống CRM" trong marketing đề cập đến gì?', 0),
('3DED44D8-5D6C-4B6A-B826-74A617D12441','6B157E9A-4F74-4EE8-A893-06BC950F4272', N'Trong tiếp thị trực tuyến, việc tối ưu hóa công cụ tìm kiếm (SEO) liên quan đến việc gì?', 0),
-- vật lý lý thuyết
('DFD68F7B-E41A-4E22-ABED-BE3024FE8462','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Đơn vị nào được sử dụng để đo khối lượng trong hệ SI (Hệ đo lường quốc tế)?', 0),
('6FFBB722-E5C1-4518-9B32-AC39EF30413E','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Đường chéo của một hình chữ nhật có chiều dài 6 cm và chiều rộng 8 cm là bao nhiêu?', 0),
('B46256AF-2BEF-4EBD-B0A6-C68271C7E4C4','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Áp suất trong lỏng là kết quả của sự tương tác giữa:', 0),
('C959BEC9-14C6-4410-870B-D8635DF194B3','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Định luật nào của Newton nói rằng "Mọi vật thể ở nghỉ sẽ ở nghỉ và mọi vật thể đang chuyển động sẽ tiếp tục chuyển động với vận tốc không đổi trừ khi có lực tác động"?', 0),
('FC0DB475-B31B-4071-B5F3-FFAFBF97BAE1','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Định nghĩa nào sau đây liên quan đến "cường độ dòng điện" trong mạch điện?', 0),
-- thiết kế đồ họa
('1C261207-3E3B-4BE2-B00D-ED72AC545E6F','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Phần mềm nào thường được sử dụng để thiết kế biểu đồ và đồ họa vector?', 0),
('F7354CD2-60D4-4AD8-8F65-74168F2984C6','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Định nghĩa nào sau đây liên quan đến "lựa chọn màu sắc" trong thiết kế đồ họa?', 0),
('E2B692C8-62CD-4388-89BF-5DF8CD404F1A','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Định nghĩa nào sau đây liên quan đến "độ phân giải" trong thiết kế đồ họa?', 0),
('81EFCF7F-1A59-4492-8FDA-A87D23D225B2','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Trong thiết kế đồ họa, "typography" đề cập đến:', 0),
('EC90458E-6A30-4D1F-8669-56259E48C92C','58824EDD-2CE6-46E8-97F3-8CA6970D8CBF', N'Đối với các hình ảnh chất lượng cao, định dạng file nào thường được sử dụng để lưu trữ hình ảnh không nén?', 0),
-- Kỹ thuật lập trình
('914C944E-AB60-4167-825C-6A1E549820A4','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong lập trình, "IDE" là viết tắt của gì?', 0),
('2F7F3FAC-AA1F-4135-BBED-53A1609E4D62','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong lập trình, kiểu dữ liệu "boolean" có bao nhiêu giá trị có thể?', 0),
('10714EF8-E0D8-4FFC-829C-82D5AB7FD6F9','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong lập trình, từ khoá "for" thường được sử dụng để làm gì?', 0),
('9B541F67-0815-4539-A890-ACAD6AB0F9FB','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Định nghĩa nào sau đây liên quan đến "biến cục bộ" trong ngôn ngữ lập trình?', 0),
('F76400C4-436E-483F-B9D0-214591034BA2','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong lập trình, "đệ quy" đề cập đến gì?', 0),
-- lập trình java
('DC731EB1-BDF2-4A41-96D2-66BA74A2C4F3','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong Java, cách nào được sử dụng để kế thừa tính năng từ một lớp cha?', 0),
('1150E405-0394-40A2-B1D0-22B1A2CDC7BD','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong Java, phạm vi truy cập nào cho phép biến hoặc phương thức chỉ được truy cập trong cùng một lớp?', 0),
('3637B505-EB79-4510-9029-C7B5739C5DC2','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong Java, cách nào được sử dụng để xử lý ngoại lệ (exception)?', 0),
('6BF8C500-148A-44D2-B811-5F94DA6C2813','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong Java, lệnh nào được sử dụng để khởi tạo một đối tượng từ một lớp?', 0),
('58260112-8759-4173-8BF3-22437B5EC181','1CFA4D8E-5F63-45F6-9CC9-B1ECAE2C14F9', N'Trong Java, một mảng có thể chứa các phần tử cùng kiểu dữ liệu. Điều gì làm cho mảng này khác biệt với danh sách (ArrayList)?', 0),
-- lập trình c#
('C7E51C94-BC0D-46BB-91DD-8D6857B14CDB','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong C#, cách nào được sử dụng để khai báo một biến kiểu số nguyên có giá trị mặc định là 0?', 0),
('6B6C7489-CD33-4A69-96C3-97711222018A','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong C#, để kế thừa từ một lớp cha, bạn sử dụng từ khóa nào?', 0),
('234DB83D-8B1D-40E1-B03E-E07160AB7612','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong C#, cách nào được sử dụng để bắt đầu một chuỗi đa dòng (multiline string)?', 0),
('E9E7173C-B205-4CD6-BCD1-13754D094A5C','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong C#, các đối tượng của lớp nào được quản lý bằng Garbage Collector để thu gom bộ nhớ không sử dụng?', 0),
('A1DAF306-0D0F-4F12-A543-51CC5088099E','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong C#, để bắt đầu một chuỗi dạng chữ in hoa (verbatim string), bạn sử dụng ký tự gì?', 0),
-- khoa học dữ liệu
('157ED4F4-7EC8-4B36-ADFF-C051940A0BD3','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong lĩnh vực khoa học dữ liệu, thuật ngữ "EDA" là viết tắt của gì?', 0),
('3B7A5325-7B97-4EB9-B936-30608EFECB28','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong phân tích dữ liệu, khái niệm nào liên quan đến việc xác định giá trị bất thường hoặc không hợp lý trong dữ liệu?', 0),
('9C785EEA-A721-4446-90B1-FCA105DAA590','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong mô hình học máy, mục tiêu của việc "tối ưu hóa" là gì?', 0),
('899B8A50-0C0B-4B6E-B109-D2C10430EB85','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Trong lĩnh vực khoa học dữ liệu, ngôn ngữ lập trình nào thường được sử dụng để thực hiện phân tích dữ liệu và xây dựng mô hình học máy?', 0),
('30CC196D-AADC-41DA-BDEC-E81156D83AC5','17593A02-3763-4B70-9454-D71C3AF0BD19', N'Khái niệm "học tăng cường" (Reinforcement Learning) là một phần của lĩnh vực nào trong khoa học dữ liệu?', 0),
-- Quản lý nhân sự
('9A644D36-BA78-4BB9-8942-270488D73006','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Đâu là một trong các chức năng chính của quản lý nhân sự?', 0),
('5E934E1A-AF48-42FB-ADB1-8FE5AD1B4ECF','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Khi thực hiện quản lý hiệu quả nhân sự, việc nào sau đây không quan trọng?', 0),
('8CC4533A-29B3-41E0-857A-2364648593BA','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Khái niệm "chấm điểm hiệu suất" trong quản lý nhân sự liên quan đến việc gì?', 0),
('3ED1B0CD-BF2A-4992-B77F-236E00F5DE51','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Đâu là một trong các phương pháp phân loại cơ bản của các khía cạnh của công việc trong phân tích công việc?', 0),
('1FF0E2E4-BFF5-4A3F-A281-7D35F5F9545E','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Khi xem xét mức độ thoả mãn của nhân viên, điều gì thường được xem xét quan trọng nhất?', 0),
-- khoa học máy tính
('5B07B8A5-D061-47A6-8258-99B79ECF193F','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Đâu là một trong các ngôn ngữ lập trình phổ biến dùng để phát triển ứng dụng web?', 0),
('2DB2046A-49B8-420C-AD34-7D06CBD07286','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'CPU là viết tắt của gì trong lĩnh vực khoa học máy tính?', 0),
('721440B0-3765-4D48-802C-F246946A97E0','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Khái niệm "Big Data" liên quan đến gì trong khoa học máy tính?', 0),
('A859A6B0-2A0C-4FA4-9D19-B257F87949BB','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Đâu là một trong các ngôn ngữ lập trình thường được sử dụng cho phân tích dữ liệu và học máy?', 0),
('7CAECEF5-F677-4F79-B340-C83A394F0582','6FCB6A47-75C2-425C-BBBD-FF7137A5FD54', N'Khái niệm "Algorithm" trong khoa học máy tính đề cập đến gì?', 0);



--
-- TABLE cautraloi
--

INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung)
VALUES
-- quản trị kinh doanh
('0BFD6940-8502-4378-B8BA-F6CE8B564C44',N'a. Chiến lược', 1),
('0BFD6940-8502-4378-B8BA-F6CE8B564C44',N'b. Tài chính', 0),
('0BFD6940-8502-4378-B8BA-F6CE8B564C44',N'c. Tiếp thị', 0),
('0BFD6940-8502-4378-B8BA-F6CE8B564C44',N'd. Tất cả các phương án trên', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'a. Mục tiêu cụ thể, đo được, có ý nghĩa, hợp lý và thời gian cụ thể', 1),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'b. Mục tiêu lớn và quan trọng', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'c. Mục tiêu chi phí thấp', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'd. Mục tiêu thu lợi nhuận cao', 0),
('813A6E29-E967-444C-915F-8246E4E09CFA',N'a. Quản lý tài nguyên và quy trình kinh doanh', 1),
('813A6E29-E967-444C-915F-8246E4E09CFA',N'b. Quản lý mối quan hệ khách hàng', 0),
('813A6E29-E967-444C-915F-8246E4E09CFA',N'c. Quản lý tài sản', 0),
('813A6E29-E967-444C-915F-8246E4E09CFA',N'd. Quản lý bán hàng', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'a. Lập kế hoạch và kiểm soát', 1),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'b. Tự doanh và tự quản lý', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'c. Đánh bại đối thủ', 0),
('9AC2242E-F45D-4299-B027-A2B77AB11BF7',N'd. Chấp nhận rủi ro mà không kiểm soát', 0);

--marketing
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('91A43CA5-A4D5-4019-B793-AEAB9F5A7253', N'a. Facebook', 1),
('91A43CA5-A4D5-4019-B793-AEAB9F5A7253', N'b. LinkedIn', 0),
('91A43CA5-A4D5-4019-B793-AEAB9F5A7253', N'c. Instagram', 0),
('91A43CA5-A4D5-4019-B793-AEAB9F5A7253', N'd. Tất cả các phương án trên', 0);

INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('9C0064AC-D17C-4591-A207-8A9B73332258', N'a. Giá, tiếp thị, sản phẩm, đo lường', 0),
('9C0064AC-D17C-4591-A207-8A9B73332258', N'b. Sản phẩm, giá, quảng cáo, tiếp thị', 1),
('9C0064AC-D17C-4591-A207-8A9B73332258', N'c. Sản phẩm, giá, chia sẻ, tiếp thị', 0),
('9C0064AC-D17C-4591-A207-8A9B73332258', N'd. Tiếp thị, đối tượng, quảng cáo, đo lường', 0);

INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('BD830252-CAE4-472D-9CB3-2E25D147EF36', N'a. Quản lý tài chính', 0),
('BD830252-CAE4-472D-9CB3-2E25D147EF36', N'b. Quản lý quan hệ khách hàng', 1),
('BD830252-CAE4-472D-9CB3-2E25D147EF36', N'c. Quản lý tài sản', 0),
('BD830252-CAE4-472D-9CB3-2E25D147EF36', N'd. Quản lý sản xuất', 0);

INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('3DED44D8-5D6C-4B6A-B826-74A617D12441', N'a. Tối ưu hóa trang web để xem dưới mọi loại trình duyệt', 0),
('3DED44D8-5D6C-4B6A-B826-74A617D12441', N'b. Xác định từ khóa phù hợp để tối ưu hóa nội dung trang web', 1),
('3DED44D8-5D6C-4B6A-B826-74A617D12441', N'c. Sử dụng quảng cáo trực tuyến hiệu quả', 0),
('3DED44D8-5D6C-4B6A-B826-74A617D12441', N'd. Xây dựng các liên kết đến trang web từ các trang web khác', 0);
-- vật lý lý thuyết
-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('DFD68F7B-E41A-4E22-ABED-BE3024FE8462', N'a. Kilogram', 1),
('DFD68F7B-E41A-4E22-ABED-BE3024FE8462', N'b. Gram', 0),
('DFD68F7B-E41A-4E22-ABED-BE3024FE8462', N'c. Pound', 0),
('DFD68F7B-E41A-4E22-ABED-BE3024FE8462', N'd. Ounce', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('6FFBB722-E5C1-4518-9B32-AC39EF30413E', N'a. 10 cm', 0),
('6FFBB722-E5C1-4518-9B32-AC39EF30413E', N'b. 14 cm', 0),
('6FFBB722-E5C1-4518-9B32-AC39EF30413E', N'c. 48 cm', 0),
('6FFBB722-E5C1-4518-9B32-AC39EF30413E', N'd. 30 cm', 1);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('B46256AF-2BEF-4EBD-B0A6-C68271C7E4C4', N'a. Khối lượng và thể tích', 0),
('B46256AF-2BEF-4EBD-B0A6-C68271C7E4C4', N'b. Khối lượng và gia tốc', 0),
('B46256AF-2BEF-4EBD-B0A6-C68271C7E4C4', N'c. Lực và diện tích', 1),
('B46256AF-2BEF-4EBD-B0A6-C68271C7E4C4', N'd. Nhiệt độ và thể tích', 0);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('C959BEC9-14C6-4410-870B-D8635DF194B3', N'a. Định luật I', 0),
('C959BEC9-14C6-4410-870B-D8635DF194B3', N'b. Định luật II', 0),
('C959BEC9-14C6-4410-870B-D8635DF194B3', N'c. Định luật III', 0),
('C959BEC9-14C6-4410-870B-D8635DF194B3', N'd. Định luật IV', 1);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('FC0DB475-B31B-4071-B5F3-FFAFBF97BAE1', N'a. Số lượng điện tích qua một điểm trong mạch mỗi giây', 1),
('FC0DB475-B31B-4071-B5F3-FFAFBF97BAE1', N'b. Tổng điện tích trong mạch', 0),
('FC0DB475-B31B-4071-B5F3-FFAFBF97BAE1', N'c. Áp suất điện trong mạch', 0),
('FC0DB475-B31B-4071-B5F3-FFAFBF97BAE1', N'd. Số vật liệu dẫn điện trong mạch', 0);

-- thiết kế đồ họa
-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('1C261207-3E3B-4BE2-B00D-ED72AC545E6F', N'a. Adobe Photoshop', 0),
('1C261207-3E3B-4BE2-B00D-ED72AC545E6F', N'b. Adobe Illustrator', 1),
('1C261207-3E3B-4BE2-B00D-ED72AC545E6F', N'c. CorelDRAW', 0),
('1C261207-3E3B-4BE2-B00D-ED72AC545E6F', N'd. Adobe InDesign', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('F7354CD2-60D4-4AD8-8F65-74168F2984C6', N'a. Màu sắc chủ đạo trong thiết kế', 1),
('F7354CD2-60D4-4AD8-8F65-74168F2984C6', N'b. Tốc độ máy tính', 0),
('F7354CD2-60D4-4AD8-8F65-74168F2984C6', N'c. Loại font chữ', 0),
('F7354CD2-60D4-4AD8-8F65-74168F2984C6', N'd. Kích thước ảnh', 0);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('E2B692C8-62CD-4388-89BF-5DF8CD404F1A', N'a. Số lượng màu sắc trong một hình ảnh', 0),
('E2B692C8-62CD-4388-89BF-5DF8CD404F1A', N'b. Kích thước của hình ảnh', 0),
('E2B692C8-62CD-4388-89BF-5DF8CD404F1A', N'c. Sự tỷ lệ giữa chiều rộng và chiều cao của hình ảnh', 0),
('E2B692C8-62CD-4388-89BF-5DF8CD404F1A', N'd. Số điểm ảnh trên mỗi inch (dpi)', 1);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('81EFCF7F-1A59-4492-8FDA-A87D23D225B2', N'a. Lựa chọn màu sắc', 0),
('81EFCF7F-1A59-4492-8FDA-A87D23D225B2', N'b. Sắp xếp các đối tượng', 0),
('81EFCF7F-1A59-4492-8FDA-A87D23D225B2', N'c. Thiết kế vùng chữ', 1),
('81EFCF7F-1A59-4492-8FDA-A87D23D225B2', N'd. Sử dụng hiệu ứng 3D', 0);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('EC90458E-6A30-4D1F-8669-56259E48C92C', N'a. JPEG', 0),
('EC90458E-6A30-4D1F-8669-56259E48C92C', N'b. GIF', 0),
('EC90458E-6A30-4D1F-8669-56259E48C92C', N'c. PNG', 0),
('EC90458E-6A30-4D1F-8669-56259E48C92C', N'd. TIFF', 1);

-- kỹ thuật lập trình
-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('914C944E-AB60-4167-825C-6A1E549820A4', N'a. Integrated Design Environment', 0),
('914C944E-AB60-4167-825C-6A1E549820A4', N'b. Integrated Development Environment', 1),
('914C944E-AB60-4167-825C-6A1E549820A4', N'c. Interactive Development Environment', 0),
('914C944E-AB60-4167-825C-6A1E549820A4', N'd. Integrated Debugging Environment', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('2F7F3FAC-AA1F-4135-BBED-53A1609E4D62', N'a. 1', 0),
('2F7F3FAC-AA1F-4135-BBED-53A1609E4D62', N'b. 2', 1),
('2F7F3FAC-AA1F-4135-BBED-53A1609E4D62', N'c. 3', 0),
('2F7F3FAC-AA1F-4135-BBED-53A1609E4D62', N'd. 4', 0);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('10714EF8-E0D8-4FFC-829C-82D5AB7FD6F9', N'a. Gọi một hàm', 0),
('10714EF8-E0D8-4FFC-829C-82D5AB7FD6F9', N'b. Kiểm tra điều kiện', 0),
('10714EF8-E0D8-4FFC-829C-82D5AB7FD6F9', N'c. Lặp qua một chuỗi lệnh', 1),
('10714EF8-E0D8-4FFC-829C-82D5AB7FD6F9', N'd. Xử lý ngoại lệ', 0);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('9B541F67-0815-4539-A890-ACAD6AB0F9FB', N'a. Biến mà có thể truy cập từ bất kỳ phạm vi nào trong chương trình', 0),
('9B541F67-0815-4539-A890-ACAD6AB0F9FB', N'b. Biến mà chỉ có thể truy cập từ phạm vi toàn cục', 0),
('9B541F67-0815-4539-A890-ACAD6AB0F9FB', N'c. Biến mà chỉ có thể truy cập từ phạm vi hàm hoặc phương thức', 0),
('9B541F67-0815-4539-A890-ACAD6AB0F9FB', N'd. Biến mà chỉ có thể truy cập từ phạm vi khối lệnh cụ thể', 1);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('F76400C4-436E-483F-B9D0-214591034BA2', N'a. Một loại kiểu dữ liệu', 0),
('F76400C4-436E-483F-B9D0-214591034BA2', N'b. Cách gọi một hàm trong chính nó', 1),
('F76400C4-436E-483F-B9D0-214591034BA2', N'c. Cách kiểm tra lỗi trong mã nguồn', 0),
('F76400C4-436E-483F-B9D0-214591034BA2', N'd. Một loại vòng lặp', 0);

-- lập trình java
-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('DC731EB1-BDF2-4A41-96D2-66BA74A2C4F3', N'a. Từ khóa super', 0),
('DC731EB1-BDF2-4A41-96D2-66BA74A2C4F3', N'b. Từ khóa extends', 1),
('DC731EB1-BDF2-4A41-96D2-66BA74A2C4F3', N'c. Từ khóa implements', 0),
('DC731EB1-BDF2-4A41-96D2-66BA74A2C4F3', N'd. Từ khóa inherit', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('1150E405-0394-40A2-B1D0-22B1A2CDC7BD', N'a. public', 0),
('1150E405-0394-40A2-B1D0-22B1A2CDC7BD', N'b. protected', 0),
('1150E405-0394-40A2-B1D0-22B1A2CDC7BD', N'c. private', 1),
('1150E405-0394-40A2-B1D0-22B1A2CDC7BD', N'd. default', 0);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('3637B505-EB79-4510-9029-C7B5739C5DC2', N'a. Từ khóa exception', 0),
('3637B505-EB79-4510-9029-C7B5739C5DC2', N'b. Từ khóa try-catch', 1),
('3637B505-EB79-4510-9029-C7B5739C5DC2', N'c. Từ khóa throw', 0),
('3637B505-EB79-4510-9029-C7B5739C5DC2', N'd. Từ khóa catch-throw', 0);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('6BF8C500-148A-44D2-B811-5F94DA6C2813', N'a. new Object();', 0),
('6BF8C500-148A-44D2-B811-5F94DA6C2813', N'b. create Object();', 0),
('6BF8C500-148A-44D2-B811-5F94DA6C2813', N'c. initialize Object();', 0),
('6BF8C500-148A-44D2-B811-5F94DA6C2813', N'd. instantiate Object();', 1);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('58260112-8759-4173-8BF3-22437B5EC181', N'a. Mảng được cố định kích thước, trong khi danh sách có thể thay đổi kích thước.', 1),
('58260112-8759-4173-8BF3-22437B5EC181', N'b. Mảng có thể chứa các kiểu dữ liệu khác nhau, trong khi danh sách chỉ chứa kiểu dữ liệu đối tượng.', 0),
('58260112-8759-4173-8BF3-22437B5EC181', N'c. Mảng chỉ cho phép truy cập vào phần tử bằng chỉ mục, trong khi danh sách cho phép truy cập bằng khóa chính.', 0),
('58260112-8759-4173-8BF3-22437B5EC181', N'd. Mảng không thể lưu trữ các phần tử có giá trị null, trong khi danh sách có thể.', 0);

-- lập trình c#
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('C7E51C94-BC0D-46BB-91DD-8D6857B14CDB', N'a. int num;', 0),
('C7E51C94-BC0D-46BB-91DD-8D6857B14CDB', N'b. var num = 0;', 1),
('C7E51C94-BC0D-46BB-91DD-8D6857B14CDB', N'c. int num = 0;', 0),
('C7E51C94-BC0D-46BB-91DD-8D6857B14CDB', N'd. var num;', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('6B6C7489-CD33-4A69-96C3-97711222018A', N'a. inherit', 0),
('6B6C7489-CD33-4A69-96C3-97711222018A', N'b. extends', 0),
('6B6C7489-CD33-4A69-96C3-97711222018A', N'c. using', 0),
('6B6C7489-CD33-4A69-96C3-97711222018A', N'd. : (Dấu hai chấm)', 1);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('234DB83D-8B1D-40E1-B03E-E07160AB7612', N'a. "chuỗi đa dòng"', 0),
('234DB83D-8B1D-40E1-B03E-E07160AB7612', N'b. ''chuỗi đa dòng''', 0),
('234DB83D-8B1D-40E1-B03E-E07160AB7612', N'c. ''''chuỗi đa dòng''', 0),
('234DB83D-8B1D-40E1-B03E-E07160AB7612', N'd. @"chuỗi đa dòng"''', 1);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('E9E7173C-B205-4CD6-BCD1-13754D094A5C', N'a. Object', 0),
('E9E7173C-B205-4CD6-BCD1-13754D094A5C', N'b. IDisposable', 0),
('E9E7173C-B205-4CD6-BCD1-13754D094A5C', N'c. System.GC', 0),
('E9E7173C-B205-4CD6-BCD1-13754D094A5C', N'd. Lớp không quản lý', 1);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('A1DAF306-0D0F-4F12-A543-51CC5088099E', N'a. !', 0),
('A1DAF306-0D0F-4F12-A543-51CC5088099E', N'b. @', 1),
('A1DAF306-0D0F-4F12-A543-51CC5088099E', N'c. #', 0),
('A1DAF306-0D0F-4F12-A543-51CC5088099E', N'd. /', 0);

-- khoa học dữ liệu

-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('157ED4F4-7EC8-4B36-ADFF-C051940A0BD3', N'a. Extra Data Analysis', 0),
('157ED4F4-7EC8-4B36-ADFF-C051940A0BD3', N'b. Exploratory Data Analysis', 1),
('157ED4F4-7EC8-4B36-ADFF-C051940A0BD3', N'c. Effective Data Assessment', 0),
('157ED4F4-7EC8-4B36-ADFF-C051940A0BD3', N'd. Essential Data Adjustment', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('3B7A5325-7B97-4EB9-B936-30608EFECB28', N'a. Data Wrangling', 0),
('3B7A5325-7B97-4EB9-B936-30608EFECB28', N'b. Data Normalization', 0),
('3B7A5325-7B97-4EB9-B936-30608EFECB28', N'c. Outlier Detection', 1),
('3B7A5325-7B97-4EB9-B936-30608EFECB28', N'd. Data Transformation', 0);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('9C785EEA-A721-4446-90B1-FCA105DAA590', N'a. Tối ưu hóa dữ liệu đầu vào', 0),
('9C785EEA-A721-4446-90B1-FCA105DAA590', N'b. Tối ưu hóa độ phức tạp của mô hình', 0),
('9C785EEA-A721-4446-90B1-FCA105DAA590', N'c. Tối ưu hóa thời gian huấn luyện', 0),
('9C785EEA-A721-4446-90B1-FCA105DAA590', N'd. Tối ưu hóa một hàm mất mát hoặc mục tiêu cụ thể', 1);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('899B8A50-0C0B-4B6E-B109-D2C10430EB85', N'a. Python', 1),
('899B8A50-0C0B-4B6E-B109-D2C10430EB85', N'b. JavaScript', 0),
('899B8A50-0C0B-4B6E-B109-D2C10430EB85', N'c. Java', 0),
('899B8A50-0C0B-4B6E-B109-D2C10430EB85', N'd. Ruby', 0);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('30CC196D-AADC-41DA-BDEC-E81156D83AC5', N'a. Phân tích dữ liệu cơ bản', 0),
('30CC196D-AADC-41DA-BDEC-E81156D83AC5', N'b. Học máy', 0),
('30CC196D-AADC-41DA-BDEC-E81156D83AC5', N'c. Quá trình Markov', 0),
('30CC196D-AADC-41DA-BDEC-E81156D83AC5', N'd. Xử lý ngôn ngữ tự nhiên', 1);

-- quản lý nhân sự
-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('9A644D36-BA78-4BB9-8942-270488D73006', N'a. Quản lý tài chính', 0),
('9A644D36-BA78-4BB9-8942-270488D73006', N'b. Quản lý sản phẩm', 0),
('9A644D36-BA78-4BB9-8942-270488D73006', N'c. Quản lý nguồn nhân lực', 1),
('9A644D36-BA78-4BB9-8942-270488D73006', N'd. Quản lý tiếp thị', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('5E934E1A-AF48-42FB-ADB1-8FE5AD1B4ECF', N'a. Lập kế hoạch nhân sự', 0),
('5E934E1A-AF48-42FB-ADB1-8FE5AD1B4ECF', N'b. Tuyển dụng và tuyển chọn nhân sự', 0),
('5E934E1A-AF48-42FB-ADB1-8FE5AD1B4ECF', N'c. Phát triển nhân lực', 0),
('5E934E1A-AF48-42FB-ADB1-8FE5AD1B4ECF', N'd. Quản lý tài chính', 1);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('8CC4533A-29B3-41E0-857A-2364648593BA', N'a. Đánh giá các dự án', 0),
('8CC4533A-29B3-41E0-857A-2364648593BA', N'b. Đánh giá nhân viên dựa trên các tiêu chí quan trọng', 1),
('8CC4533A-29B3-41E0-857A-2364648593BA', N'c. Đánh giá tình hình tài chính của công ty', 0),
('8CC4533A-29B3-41E0-857A-2364648593BA', N'd. Đánh giá thị trường cạnh tranh', 0);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('3ED1B0CD-BF2A-4992-B77F-236E00F5DE51', N'a. Phân loại công việc theo địa điểm làm việc', 0),
('3ED1B0CD-BF2A-4992-B77F-236E00F5DE51', N'b. Phân loại công việc theo thời gian làm việc', 0),
('3ED1B0CD-BF2A-4992-B77F-236E00F5DE51', N'c. Phân loại công việc theo nhóm công việc tương tự', 1),
('3ED1B0CD-BF2A-4992-B77F-236E00F5DE51', N'd. Phân loại công việc theo mức độ khó khăn', 0);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('1FF0E2E4-BFF5-4A3F-A281-7D35F5F9545E', N'a. Lương và phúc lợi', 0),
('1FF0E2E4-BFF5-4A3F-A281-7D35F5F9545E', N'b. Môi trường làm việc', 0),
('1FF0E2E4-BFF5-4A3F-A281-7D35F5F9545E', N'c. Cơ hội thăng tiến', 0),
('1FF0E2E4-BFF5-4A3F-A281-7D35F5F9545E', N'd. Tài năng và kỹ năng cá nhân', 1);

-- khoa học máy tính
-- Câu trả lời cho câu hỏi 1
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('5B07B8A5-D061-47A6-8258-99B79ECF193F', N'a. C++', 0),
('5B07B8A5-D061-47A6-8258-99B79ECF193F', N'b. Python', 0),
('5B07B8A5-D061-47A6-8258-99B79ECF193F', N'c. Java', 1),
('5B07B8A5-D061-47A6-8258-99B79ECF193F', N'd. HTML', 0);

-- Câu trả lời cho câu hỏi 2
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('2DB2046A-49B8-420C-AD34-7D06CBD07286', N'a. Central Processing Unit', 1),
('2DB2046A-49B8-420C-AD34-7D06CBD07286', N'b. Computer Processing Unit', 0),
('2DB2046A-49B8-420C-AD34-7D06CBD07286', N'c. Control Processing Unit', 0),
('2DB2046A-49B8-420C-AD34-7D06CBD07286', N'd. Central Program Unit', 0);

-- Câu trả lời cho câu hỏi 3
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('721440B0-3765-4D48-802C-F246946A97E0', N'a. Cơ sở dữ liệu lớn', 0),
('721440B0-3765-4D48-802C-F246946A97E0', N'b. Phân tích dữ liệu lớn', 1),
('721440B0-3765-4D48-802C-F246946A97E0', N'c. Lưu trữ dữ liệu lớn', 0),
('721440B0-3765-4D48-802C-F246946A97E0', N'd. Xử lý dữ liệu lớn', 0);

-- Câu trả lời cho câu hỏi 4
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('A859A6B0-2A0C-4FA4-9D19-B257F87949BB', N'a. JavaScript', 0),
('A859A6B0-2A0C-4FA4-9D19-B257F87949BB', N'b. Ruby', 0),
('A859A6B0-2A0C-4FA4-9D19-B257F87949BB', N'c. R', 1),
('A859A6B0-2A0C-4FA4-9D19-B257F87949BB', N'd. Swift', 0);

-- Câu trả lời cho câu hỏi 5
INSERT INTO cautraloi(macauhoi, noidung, lacautraloidung) VALUES
('7CAECEF5-F677-4F79-B340-C83A394F0582', N'a. Một loại phần mềm', 0),
('7CAECEF5-F677-4F79-B340-C83A394F0582', N'b. Một thiết bị máy tính', 0),
('7CAECEF5-F677-4F79-B340-C83A394F0582', N'c. Một tập hợp các hướng dẫn để giải quyết một vấn đề', 1),
('7CAECEF5-F677-4F79-B340-C83A394F0582', N'd. Một hệ điều hành', 0);


UPDATE lophoc SET daxoa=0
UPDATE chuong SET daxoa=0
UPDATE dekiemtra SET daxoa=0
UPDATE cauhoi SET daxoa=0
UPDATE baitap SET daxoa=0
UPDATE baitap SET congkhaidapan=0