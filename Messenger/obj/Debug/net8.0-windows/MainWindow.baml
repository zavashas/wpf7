   M S B A M L   `   `   `  ����D  @Messenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Messenger	Messenger  5   	       Messenger.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Messenger     5   	     � Title$  
Чатик��5	      $	��400��6   $	��400��6/   $	��400��6<   $	��400��6K   .��5
      �  � RowDefinitions 5   
   �� 5      $��30��6   $��* �6+   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��5      $��Center=�5      $��Center=�6*   $��20(�5      $?��9Добро пожаловать в сетевой чат!��5      �� 5   
   -   5         ��Name$
 Name��5      $��1��5      $��	10 0 10 0q�5      $��Center=�5         MaterialDesignFilledTextBox#��[  5       �� AcceptsReturn$ False��5       �� TextWrapping$ NoWrap=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$= 7Введите свое имя пользователя��5      �� 5   
   -   5         ��Name$ Create��5      $��2��5       $��10q�6   $��Создать новый��5!      6%   �� 5"   
   -   5        $ Connect��5"      $��3��5#      $��10q�6   $��Подключиться��5$      6$   �� 5%   
   -   5        $ IP��5%      $��4��5&      $��
10 0 10 10q�5'      $��Center=�5(      #��[  5)      $ False��5*      $ NoWrap=�5+      $ IP адрес чата��5,      5-      5.      