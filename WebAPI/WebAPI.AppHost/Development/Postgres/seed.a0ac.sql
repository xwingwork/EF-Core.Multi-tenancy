-- 使用資料庫
\c a0ac;

-- 創建資料表
CREATE TABLE hr010
(
  comps character(36) NOT NULL DEFAULT ''::bpchar,
  comp character(20) NOT NULL DEFAULT ''::bpchar,
  unino character(8) NOT NULL DEFAULT ''::bpchar,
  comp_name character varying(100) NOT NULL DEFAULT ''::bpchar,
  comp_name_short character varying(50) NOT NULL DEFAULT ''::bpchar,
  comp_en character varying(200) NOT NULL DEFAULT ''::bpchar,
  orgmark character(1) NOT NULL DEFAULT ''::bpchar,
  lang character(1) NOT NULL DEFAULT ''::bpchar,
  org_empname character varying(50) NOT NULL DEFAULT ''::bpchar,
  title character varying(50) NOT NULL DEFAULT ''::bpchar,
  fiorg character(5) NOT NULL DEFAULT ''::bpchar,
  taxid character(12) NOT NULL DEFAULT ''::bpchar,
  labno character(20) NOT NULL DEFAULT ''::bpchar,
  heano character(20) NOT NULL DEFAULT ''::bpchar,
  heano_ar character(2) NOT NULL DEFAULT ''::bpchar,
  phone character varying(250) NOT NULL DEFAULT ''::bpchar,
  phone_fax character varying(20) NOT NULL DEFAULT ''::bpchar,
  adzip character(10) NOT NULL DEFAULT ''::bpchar,
  adcity character varying(14) NOT NULL DEFAULT ''::bpchar,
  adcity2 character varying(16) NOT NULL DEFAULT ''::bpchar,
  adother character varying(1000) NOT NULL DEFAULT ''::bpchar,
  adother2 character varying(500) NOT NULL DEFAULT ''::bpchar,
  dt_start character(8) NOT NULL DEFAULT ''::bpchar,
  dt_stop character(8) NOT NULL DEFAULT ''::bpchar,
  website character varying(100) NOT NULL DEFAULT ''::bpchar,
  email character varying(50) NOT NULL DEFAULT ''::bpchar,
  date_modi character(8) NOT NULL DEFAULT ''::bpchar,
  time_modi character(6) NOT NULL DEFAULT ''::bpchar,
  empno_modi character(20) NOT NULL DEFAULT ''::bpchar,
  date_cret character(8) NOT NULL DEFAULT to_char(now(), 'YYYYMMDD'::text),
  time_cret character(6) NOT NULL DEFAULT to_char(now(), 'HH24MISS'::text),
  empno_cret character(20) NOT NULL DEFAULT ''::bpchar,
  date_tran character(8) NOT NULL DEFAULT ''::bpchar,
  time_tran character(6) NOT NULL DEFAULT ''::bpchar,
  empno_tran character(20) NOT NULL DEFAULT ''::bpchar,
  empname_tax character varying(50) NOT NULL DEFAULT ''::bpchar,
  taxid2 character(12) NOT NULL DEFAULT ''::bpchar,
  adzip_tax character(10) NOT NULL DEFAULT ''::bpchar,
  adcity_tax character varying(14) NOT NULL DEFAULT ''::bpchar,
  adcity2_tax character varying(16) NOT NULL DEFAULT ''::bpchar,
  adother_tax character varying(500) NOT NULL DEFAULT ''::bpchar,
  adother2_tax character varying(500) NOT NULL DEFAULT ''::bpchar,
  insno character(8) DEFAULT ''::bpchar,
  bank character varying(3) DEFAULT ''::bpchar,
  account character varying(250) DEFAULT ''::bpchar,
  stype3 character(1) DEFAULT ''::character(1),
  app_service_uuid character(36) DEFAULT ''::character(1),
  fiorg1 character(5) NOT NULL DEFAULT ''::bpchar,
  CONSTRAINT hr010_pkey PRIMARY KEY (comps, comp, orgmark, unino)
)
WITH (
  OIDS=FALSE
);


-- 創建 Seed Data
--震旦雲端事業部
INSERT INTO hr010(
            comps, comp, unino, comp_name, comp_name_short, comp_en, orgmark, 
            lang, org_empname, title, fiorg, taxid, labno, heano, heano_ar, 
            phone, phone_fax, adzip, adcity, adcity2, adother, adother2, 
            dt_start, dt_stop, website, email, date_modi, time_modi, empno_modi, 
            date_cret, time_cret, empno_cret, date_tran, time_tran, empno_tran, 
            empname_tax, taxid2, adzip_tax, adcity_tax, adcity2_tax, adother_tax, 
            adother2_tax, insno, bank, account, stype3, app_service_uuid, 
            fiorg1)
VALUES
('','a0ac','00000000','我該停用','停','','2','','','','','','','','','','','','','','','','','20231201','','','20231215','142128','admin','20231215','142120','admin','','','','','','','','','','','00000000','','','','',''),
('','a0ac','22912255','客服事業部','客服事事業','shine','2','','','','','','01999999B','12345689','01','','','','','','','','','','','','20211228','111635','0000000046','20151130','115827','0000000054','','','','','','','','','','','03568400','011','4555131248978','','',''),
('','a0ac','27332404','職工福利委員會','震旦職工福利委員會','','3','','','','','','AA1234567','AA123456789','01','','','','','','','','','','','','20230716','235945','admin','20191023','114618','admin','','','','','','','','','','','27332404','006','1234567899999','','',''),
('','a0ac','84355146','震旦3D事業','3D事業','','3','','','','A10','100805893','987654321','61465106','01','','','','','','','','','','','','20230202','090814','0000000046','20151016','150549','0000000004','','','','瓦城','F18024833000','','','','','新北市中和區','84355146','','','','','A1000'),
('','a0ac','87756881','震旦家具','震旦家具','','3','','','','','','123456789','5678901234','01','','','','','','','','','','','','20190522','172336','0000000004','20150827','143056','admin','','','','','','','','','','','87756881','','','','',''),
('56be0add-45ba-4166-94ec-c3ed6154ec8f','a0ac','03568400','震旦雲','震旦雲端事業部','','1','','','總經理','A03','0378F7777','01999999B','12345689','01','','','110','臺北市','信義區','信義路五段2號7樓','','20140501','','','','20231225','171029','admin','20140630','172947','','20250113','160604','system','陳翠華','A12345678987','','','','','台北市信義區五段2號7樓','03568400','','5112364851354687','','4ef20c27-1751-45b4-bf37-47842e1f135e','A0300');