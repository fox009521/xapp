# T_Medical_His病历夹表
<table cellspacing="0" cellpadding="5" border="1" width="100%" bordercolorlight="#D7D7E5" bordercolordark="#D3D8E0">
         <tbody>
          <tr bgcolor="#F0F0F0">
           <td>序号</td>
           <td>列名</td>
           <td>数据类型</td>
           <td>长度</td>
           <td>小数位</td>
           <td>标识</td>
           <td>主键</td>
           <td>外键</td>
           <td>允许空</td>
           <td>默认值</td>
           <td>说明</td>
          </tr>
          <tr>
           <td>1</td>
           <td>id</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">病历夹ID</td>
          </tr>
          <tr>
           <td>2</td>
           <td>His_Gid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>newid</td>
           <td align="left">病历夹标识</td>
          </tr>
          <tr>
           <td>3</td>
           <td>Doctor_ID</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">医生ID</td>
          </tr>
          <tr>
           <td>4</td>
           <td>Patient_ID</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">病人ID</td>
          </tr>
          <tr>
           <td>5</td>
           <td>Sickness</td>
           <td>nvarchar</td>
           <td>100</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">所患疾病</td>
          </tr>
          <tr>
           <td>6</td>
           <td>CreateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>getdate</td>
           <td align="left">创建时间</td>
          </tr>
          <tr>
           <td>7</td>
           <td>UpdateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">更新时间</td>
          </tr>
          <tr>
           <td>8</td>
           <td>status</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>1</td>
           <td align="left">记录状态</td>
          </tr>
         </tbody>
        </table>
#建表语句
<pre>
<code>
--病历夹表
CREATE TABLE T_Medical_His
(
	id int identity(1,1),--病历夹ID
	His_Gid nvarchar(40) default newid(),--病历夹标识
	Doctor_ID nvarchar(64) not null, --医生ID
	Patient_ID nvarchar(64) not null,--病人ID
	Sickness nvarchar(100) not null,--所患疾病
	CreateTime datetime default getdate(),--创建时间
	UpdateTime datetime,--更新时间
	status int default 1--记录状态
)

</code>
</pre>
