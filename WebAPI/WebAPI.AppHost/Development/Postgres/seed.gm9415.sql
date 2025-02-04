-- 使用資料庫
\c gm9415;

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
--汎美
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
('','gm9415','53853132','桃市公寓大廈工會','桃市公寓大廈工會','','2','','','','','','10000000T','100000000','','','','','','','','','','','','','20160411','104129','admin','20160411','103959','admin','','','','','','','','','','','53853132','','','','',''),
('','gm9415','01681969','金讚清潔社','金讚','','2','','','','','','000000000','0','','','','','','','','','','','','','','','','20141231','141420','admin','','','','','','','','','','','01681969','','','','',''),
('','gm9415','41435303','泛美清潔社','泛美清潔社','','2','','陳淑敏','','','','01425353K','147606442','02','','','','','','','','','','','','20190306','141724','0000000656','20190125','094446','0000000658','','','','','','','','','','','41435303','808','0185940026783','','',''),
('','gm9415','87756881','潔美清潔打臘行','潔美清潔','','2','','','','','','01425372G','138810992','02','','','','','','','','','','','','20150501','152730','admin','20141231','140911','admin','','','','','','','','','','','87756881','808','0185940010583','','',''),
('','gm9415','83197373','緯均企業有限公司','緯均企業','','2','','','','','','01445302A','150117034','02','','','','','','','','','','','','20200924','160057','0000000656','20200924','151828','0000000656','','','','','','','','','','','83197373','808','0185940028955','','',''),
('','gm9415','27849859','汎渼清潔有限公司','汎清','','2','','','','','','01278660T','131838983','02','','','','','','','','','','','','20150501','152705','admin','20141231','140448','admin','','','','','','','','','','','27849859','808','0185440026405','','',''),
('','gm9415','24608287','汎渼國際有限公司','汎渼國際','','2','','','','','','01376898B','141376641','02','','','','','','','','','','','','20150501','152757','admin','20141231','140616','admin','','','','','','','','','','','24608287','808','0185940020798','','',''),
('','gm9415','80398191','日日新清潔有限公司','日日新','','2','','','','','','01320204Y','135232889','02','','','','','','','','','','','','20150501','152824','admin','20141231','141021','admin','','','','','','','','','','','80398191','808','0185940011105','','',''),
('','gm9415','29094054','潔昌清潔服務有限公司','潔昌','','2','','','','','','01361353F','139254952','02','','','','','','','','','','','','20180808','112319','0000000656','20141231','141148','admin','','','','','','','','','','','29094054','808','0185940026256','','',''),
('','gm9415','53965495','泛美清潔有限公司','泛美','','2','','','','','','01351366A','138239620','02','','','','','','','','','','','','20150501','152856','admin','20141231','141306','admin','','','','','','','','','','','53965495','808','1090440005372','','',''),
('','gm9415','54930880','汎渼環保服務有限公司','汎環','','2','','','','','','01416808H','146578047','02','03-3133890','','','','','桃園市蘆竹區大竹路335巷7弄10號1樓','','','','','','20180515','113532','0000000661','20180510','134158','0000000661','','','','','','','','','','','54930880','808','0185940026203','','',''),
('','gm9415','89121203','泛美家事清潔有限公司','泛美家事清潔有限公司','','2','','周亭緯','','','','01474601F','153509070','02','03-3921007','','','','','','','','','','','20230214','130950','0000000658','20230214','102531','0000000658','','','','','','','','','','','89121203','808','0185940032188','','',''),
('27ef9d0b-4b92-44e9-9a19-63331fb80d3f','gm9415','16264013','汎渼企業有限公司','汎渼企業','','1','','','','','','05408512W','125845196','02','','','','','','','','','','','','20151006','104025','admin','20141224','192138','','20250115','135511','system','','','','','','','','16264013','808','0185440018305','','','');