# T_Medical_HisDetailPic病历详细图片表
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
           <td align="left">图片ID</td>
          </tr>
          <tr>
           <td>2</td>
           <td>Pic_Gid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>newid</td>
           <td align="left">图片标识</td>
          </tr>
          <tr>
           <td>3</td>
           <td>Detail_Gid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">病历记录ID</td>
          </tr>
          <tr>
           <td>4</td>
           <td>Pic_Url</td>
           <td>nvarchar</td>
           <td>255</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">图片路径</td>
          </tr>
          <tr>
           <td>5</td>
           <td>CreateUser</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">记录人</td>
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
           <td align="left">新增时间</td>
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
           <td>getdate</td>
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
--病历详细图片表
CREATE TABLE T_Medical_HisDetailPic
(
	id int identity(1,1), --图片ID
	Pic_Gid nvarchar(40) default newid(), --图片标识
	Detail_Gid nvarchar(40) not null, --病历记录ID
	Pic_Url nvarchar(255), --图片路径
	CreateUser nvarchar(64),--记录人
	CreateTime datetime default getdate(),--新增时间
	UpdateTime datetime default getdate(),--更新时间
	status int default 1--记录状态
)
</code>
</pre>
