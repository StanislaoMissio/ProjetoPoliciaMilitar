   M S B A M L   `   `   `  ����D  @ProjetoPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProjetoPI	ProjetoPI  5   	   X TXceed.Wpf.Toolkit, Version=2.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5   	       ProjetoPI.TelaInicial   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ProjetoPI     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	     � Title$  Tela Inicial��5	   	   $	��500��6   $	��300��6*    � WindowStartupLocation$ CenterScreen=�67   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��79* �6   �� 5      $	��44* �6   .+�5   
   �� -   5         ��Name$ txtPesquisa��5      $��Pesquisar... ��6'   $��20��6<   $��Stretch=�6H   $	��Top=�6f   
������ 6~   �� 5   
   -   5         ��Name$ btnPesquisar��5      $��Right=�6'   $	��Top=�6C   $��20��6[   
������ 
������ $��20��6�   .��5      �� $0��*/ProjetoPI;component/Resource/Pesquisa.png��6   5      �� 5   
   -   5        $ btnTelaCadastrarFunc��5      $��Stretch=�6/   $	��Top=�6M   $��1��6e   $��35��6u   
������ 
������ .��5      �  5      �� 5      $	��28* �6'   �� 5      $
��187* �6'   .+�5      �� $3��-/ProjetoPI;component/Resource/Funcionario.png��6   $��0��6O   $
��Left=�6_   �� 5      $��Cadastrar Funcionário��6   $��1��68   $��Right=�6H   5      5      �� 5   
   -   5        $ btnCadastrarOcorrencia��5      $��Stretch=�61   $	��Top=�6O   $��1��6g   $��35��6w   $��0,70,0,0q�6�   
������ 
������ .��5      �  5      �� 5       $	��28* �6'   �� 5!      $
��187* �6'   .+�5#      �� $2��,/ProjetoPI;component/Resource/Ocorrencia.png��6   $��0��6N   �� 5$      $��Cadastrar Ocorrência��6   $��1��67   5%      5&      �� 5'   
   -   5        $ btnGerarRelatorio��5'      $��Stretch=�6,   $	��Top=�6J   $��1��6b   $��35��6r   $��	0,140,0,0q�6~   
������ 
������ .��5(      �  5)      �� 5*      $	��28* �6'   �� 5+      $
��187* �6'   .+�5-      �� $1��+/ProjetoPI;component/Resource/Relatorio.png��6   $��0��6M   �� 5.      $��Gerar Relatório��6   $��1��62   5/      50      �� 51   
   -   5         ��Name$ listBox��51      $
��Left=�6$   $	��234��6?   $��	10,25,0,0q�6L   $	��Top=�6_   $	��296��6w   52      53      54      