   M S B A M L   `   `   `  ����F  BModernLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ModernLoginModernLogin  5   	       ModernLogin.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ModernLogin     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ 
MainWindow��5   	   $	��500��6   $	��350��6)    � 
ResizeMode$ NoResize=�65   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFcd2e53��6#   � 5      $ 	#FFc32b4e��6#    � Offset$ 1Q�65   � 5      $ 	#FF9c1b39��6#   $	 0.5Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusX$ 15��6d   	 �� RadiusY$	 15��6q   
 J� Effect
 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         Color$ 	#FFB4B4B4��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S   5#      � 5$   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5%      �� $��LOGIN��6   $��Center=�6%   $	��TOP=�6B   $��5q�6Z   
�������$��20(�6w   �� 5&      $��Center=�6   .+�5'      �� -   5         ��Name$ txtUser��5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6+    % !MaterialDesignFloatingHintTextBox#��[ 6R   $��10q�6�   6�   �� 5(      -   5        $ txtPass��5(      $ Password��6+   #��[ 6U   $��
0,10,10,10q�6�   $��Right=�6�   $	��260��6�   5)      5*      �� 5+   
   -   5        $��Log in��5+      $
��Left=�6"   $��108,350,0,0q�6=   $	��Top=�6R   $	��132��6j   ���#930f2e$��39��6�   6�   5-      5.      