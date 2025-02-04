-- 使用資料庫
\c oacloud;

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
--震旦雲│雲端人資系統展示平台
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
('','oacloud','00000000','12345678','12345678','','3','','','','','','','','','','','','','','','','','20210412','','','20210412','135537','admin','20210412','135223','admin','','','','','','','','','','','00000000','','','','',''),
('','oacloud','44246755','大家好','大家好','hello','3','','sss','','','','','','','','','413','臺中市','霧峰區','','','','','','','','','','20210616','112328','admin','','','','','','','','','','','44246755','008','','','',''),
('','oacloud','24928818','ATC','適才顧','','3','','','','','','','','','','','','','','','','','','','','','','','20210901','211423','0000000028','','','','','','','','','','','24928818','','','','',''),
('','oacloud','12637477','測試企業','ＴＥＳＴ','','3','','','','','','','','','','','','','','','','','','','','20210824','003116','0000000018','20210824','002722','0000000018','','','','','','','','','','','12637477','','','','',''),
('','oacloud','23362601','金震科技股份有限公司','金震科','','2','','林智穎','總經理','','','05435463H','121885952','02','','','','','','','','','','','','20161122','205858','0000000035','20161122','205903','0000000035','','','','','','','','','','','03568400','','','','',''),
('','oacloud','24277152','永圓','永圓','','3','','','','','','05435463H','121885952','02','','','','','','','','','','','','','','','20201118','103035','0000000018','','','','','','','','','','','03568400','','','','',''),
('','oacloud','28418034','test111','test111','','2','','','','','','05435463H','121885952','02','','','','','','','','20170818','','','','20170820','230821','0000000018','20170820','230650','0000000018','','','','','','','','','','','03568400','','','','',''),
('','oacloud','28936091','雷傑科技','KJET','','2','','','','','','05435463H','121885952','02','','','','','','','','','','','','20170220','012456','0000000028','20170220','102029','0000000028','','','','','','','','','','','03568400','007','','','',''),
('','oacloud','37909525','TEST新','TEST新','','3','','','','','','05435463H','121885952','02','','','','','','','','','','','','20190628','150915','0000000018','20190627','174821','0000000018','','','','','','','','','','','03568400','','','','',''),
('','oacloud','42703100','吉茂精密股份有限公司','吉茂','','2','','','','','','05435463H','121885952','02','','','','','','','','','','','','20190121','155625','admin','20170413','162115','0000000018','','','','','','','','','','','03568400','','','','',''),
('','oacloud','12516262','跑跑跑','ch','RRR','3','','NNN','ck','','','05435463H','121885952','02','22222222','','110','臺北市','信義區','','','20211006','','','','20211006','142934','admin','20170912','143151','0000000028','','','','','','','','','','','03568400','004','','','',''),
('','oacloud','14533941','社團法人台灣蘭花產銷發展協會','蘭協','','3','','陳澄澄','理事長','','','05435463H','121885952','02','066830304','','731','臺南市','後壁區','長安里325號','','','','','','20191023','114845','0000000028','20191022','160213','0000000028','','','','','','','','','','','03568400','','','','',''),
('','oacloud','43720839','八德教養院永豐院區','八德教養院','','2','','','','','','05435463H','121885952','02','','','','','','','','','','','','','','','20191113','141727','0000000028','','','','','','','','','','','03568400','','','','',''),
('','oacloud','54787884','翔霖','ㄤ咕','','3','','','','','','05435463H','121885952','02','','','','','','','','','','','','20210915','110848','admin','20190422','204941','0000000018','','','','','','','','','','','03568400','','','','',''),
('','oacloud','78628366','***','***','','2','','','','','','05435463H','121885952','02','','','','','','','','','','','','20170118','111949','0000000028','20170118','111801','0000000028','','','','','','','','','','','03568400','','','','',''),
('','oacloud','80057200','btc','btc','','2','','','','','','05435463H','121885952','02','','','','','','','','','','','','','','','20200317','134451','admin','','','','','','','','','','','03568400','','','','',''),
('','oacloud','86156488','EZ','億展','','3','','','','','','','','','','','','','','','','','','','','20210901','091258','0000000028','20210901','210920','0000000028','','','','','','','','','','','52920056','','','','',''),
('','oacloud','86244841','智凡迪科技','智凡迪','','2','','','','','','05435463H','121885952','02','','','','','','','','','','','','20191114','180931','admin','20171121','173943','0000000028','','','','','','','','','','','03568400','','','','',''),
('','oacloud','89799801','123','ok','ok','2','','test','','','','05435463H','121885952','02','','','','','','test789','','','','','','20190422','212959','0000000018','20170114','131117','0000000028','','','','','','','','','','','03568400','','','','',''),
('','oacloud','00000016','20220331測試公司','20220331測試公司','','3','','','','','','','','','','','','','','','','20160101','','','','20220331','175018','admin','20220331','174753','admin','','','','','','','','','','','00000016','004','','','',''),
('','oacloud','28207988','成功股份有限公司','成功','','3','','陳成功','','','','05435463H','121885952','02','','','','','','','','','','','','20220321','233948','0000000018','20180808','145559','0000000028','','','','','','','','','','','03568400','','','','',''),
('4158b22a-cb9e-48c8-a729-7b1bd9ed8f4c','oacloud','03568400','震旦雲│雲端人資系統展示平台','震旦','OpenNetwork','1','','','董事長','C03','0356F8400','05435463H','121885952','02','','','110','臺北市','信義區','信義路五段1號4樓','','','','','','20220321','131825','admin','20141027','102909','','20250108','115007','system','林智穎','A17190837001','','','','','台北市信義區信義路五段二號15F','03568400','','','','2c22f8e3-761c-4cb3-8dda-acb2594da5cf','');