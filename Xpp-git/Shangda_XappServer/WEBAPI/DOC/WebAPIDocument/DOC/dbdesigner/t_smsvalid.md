# T_SmsValid短信验证表
<table border="0" cellpadding="5" cellspacing="0" width="90%"><tbody><tr><td bgcolor="#F5F9FF"><table cellspacing="0" cellpadding="5" border="1" width="100%" bordercolorlight="#4F7FC9" bordercolordark="#D3D8E0"><tbody><tr bgcolor="#E3EFFF"><td>序号</td><td>列名</td><td>数据类型</td><td>长度</td><td>小数位</td><td>标识</td><td>主键</td><td>外键</td><td>允许空</td><td>默认值</td><td>说明</td></tr><tr><td>1</td><td>SmsID</td><td>int</td><td>4</td><td>0</td><td>是</td><td>是</td><td>&nbsp;</td><td>否</td><td>&nbsp;</td><td align="left">&nbsp;</td></tr><tr><td>2</td><td>smsGID</td><td>nvarchar</td><td>128</td><td>0</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>newid</td><td align="left">&nbsp;</td></tr><tr><td>3</td><td>Phone</td><td>nvarchar</td><td>20</td><td>0</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">手机号码</td></tr><tr><td>4</td><td>StartTime</td><td>datetime</td><td>8</td><td>3</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">短信有效开始时间</td></tr><tr><td>5</td><td>EndTime</td><td>datetime</td><td>8</td><td>3</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">短信有效结束时间</td></tr><tr><td>6</td><td>ValidStatus</td><td>int</td><td>4</td><td>0</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">验证状态</td></tr><tr><td>7</td><td>ValidCode</td><td>nvarchar</td><td>20</td><td>0</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">验证码</td></tr><tr><td>8</td><td>ValidType</td><td>int</td><td>4</td><td>0</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">验证类型</td></tr><tr><td>9</td><td>CreateTime</td><td>datetime</td><td>8</td><td>3</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>getdate</td><td align="left">&nbsp;</td></tr><tr><td>10</td><td>UpdateTime</td><td>datetime</td><td>8</td><td>3</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">&nbsp;</td></tr><tr><td>11</td><td>Status</td><td>int</td><td>4</td><td>0</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>是</td><td>&nbsp;</td><td align="left">&nbsp;</td></tr></tbody></table></td></tr></tbody></table>