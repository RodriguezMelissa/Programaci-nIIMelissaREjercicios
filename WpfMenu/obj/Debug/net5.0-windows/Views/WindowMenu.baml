   M S B A M L   `   `   `  ����B  >WpfMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfMenu.ViewsWpfMenu.Views  5   	       WpfMenu.Views.WindowMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'localclr-namespace:WpfMenu.Views  5   	     � Title$  
WindowMenu��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��360* �6   6.   .+�5   
   o� -   5         o�Name$
 Menu��5       o� 
IsMainMenu$
 True��6   $��0��60   $��0��6=   .@�5      m� $��Aplicación��6   .@�5      m� -   5        $��btnConfigurar��5   /   $��
Configurar��6    m� Icon 5      '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$
 Gear=�62   5      m� 5      -   5        $��btnSalir��5      $��Salir��6-    5        5      $ 	ExitToApp=�62   5      5      m� 5      $��Miscelaneos��6   .@�5      m� -   5        $��	btnTextos��5      $��Textos��6.    5        5      $
 Text=�62   5       m� 5!      $��	Localidad��6   .@�5"      m� -   5        $��btnnicaragua��5"      $��
 Nicaragua��63   6G   5%      m� 5&      -   5        $��btnConvertidordemonedas��5&      $��Convertidor de Monedas��6<    5'        5(      $ Money=�62   5*      5+      5.      51      52      