# T_Template康复模版
<table border="0" cellpadding="5" cellspacing="0" width="90%">
                <tr>
                    <td bgcolor="#F5F9FF">
                        <table cellspacing="0" cellpadding="5" border="1" width="100%" bordercolorlight="#4F7FC9" bordercolordark="#D3D8E0">
                            <tr bgcolor="#E3EFFF">
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
                                <td>TemplateID</td>
                                <td>int</td>
                                <td>4</td>
                                <td>0</td>
                                <td>是</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>TemplateGID</td>
                                <td>nvarchar</td>
                                <td>128</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>newid</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>TemplateName</td>
                                <td>nvarchar</td>
                                <td>128</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>TemplateMemo</td>
                                <td>nvarchar</td>
                                <td>512</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td>DocotorMID</td>
                                <td>nvarchar</td>
                                <td>64</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>6</td>
                                <td>TeamMID</td>
                                <td>nvarchar</td>
                                <td>64</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>7</td>
                                <td>TemplateType</td>
                                <td>int</td>
                                <td>4</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>8</td>
                                <td>ApplicationType</td>
                                <td>int</td>
                                <td>4</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>否</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>9</td>
                                <td>BAK1</td>
                                <td>nvarchar</td>
                                <td>512</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>10</td>
                                <td>BAK2</td>
                                <td>nvarchar</td>
                                <td>512</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>11</td>
                                <td>CreateName</td>
                                <td>nvarchar</td>
                                <td>128</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>12</td>
                                <td>CreateTime</td>
                                <td>datetime</td>
                                <td>8</td>
                                <td>3</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>13</td>
                                <td>UpdateName</td>
                                <td>nvarchar</td>
                                <td>128</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>14</td>
                                <td>UpdateTime</td>
                                <td>datetime</td>
                                <td>8</td>
                                <td>3</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>15</td>
                                <td>IsDel</td>
                                <td>int</td>
                                <td>4</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>16</td>
                                <td>Status</td>
                                <td>int</td>
                                <td>4</td>
                                <td>0</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>是</td>
                                <td>&nbsp;</td>
                                <td align="left">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>