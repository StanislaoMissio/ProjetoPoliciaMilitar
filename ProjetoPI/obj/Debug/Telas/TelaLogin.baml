   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=2.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5   	   D @ProjetoPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProjetoPI	ProjetoPI 5   	      ProjetoPI.TelaLogin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	   )localclr-namespace:ProjetoPI     5   	   -   5          � Title$  Login��5	   	   $	��240��6   $	��400��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   .��5
      � .+�5   
   �� -   5         ��Name$ image��5      $
��Left=�6   $	��203��6:   $	��Top=�6G   $	��212��6_    � Cursor$ No��6k   $:��4/ProjetoPI;component/Resource/PoliciaMilitarLogo.jpg��6w    J� Opacity$	 0.4Q�6�   �� 5   
   -   5         ��Name$ lblRE��5      $��RE��6   $
��Left=�6,   $��171,153,0,0q�6G   $	��Top=�6\   $��16(�6t   �� 5   
   -   5        $ lblSenha��5      $��Senha��6"   $
��Left=�62   $	��Top=�6M   $��146,174,0,0q�6e   $��16(�6z   %   Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ txtRE��5       $
��Left=�6/   $��23��6J   $	��Top=�6W   $��55��6o   $��219,153,0,0q�6z      Mask$ 000000-0��6�   G� 5   
   -   5        	 G�Name$	 txtSenha��5      $
��Left=�6(   $��219,181,0,0q�6C   $	��Top=�6X   $	��165��6p   $��22��6|   �� 5   
   -   5        
 ��Name$
 btnLogin��5      $��Login��6#   $
��Left=�63   $	��Top=�6N   $��76��6f   $��308,117,0,0q�6q   $��29��6�   $��16(�6�   5      5      