   M S B A M L   `   `   `  ����  CarShowroomWorkstation0    *CarShowroomWorkstation.AuthorizationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  AuthorizationWindow��5   	   $	��450��6%   $	��700��62    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	   ��5      �� 5   
    �� ImageSource$5 /pack://application:,,,/Resources/BackGround.png��6   .��5      �  +� FocusedElement 6   ��  �� ElementName$ EmailTextBox�� � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��110 �6   6+   �� 5      $��50 �6   6*   �� 5      $��60 �6   6*   �� 5      $��50 �6   6*   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ 	EmaiLabel��5      $��Email��6#      
LabelStyle#��[  63   �� 5   
   -   5        	 ��Name$	 EmailTextBox��5      $��1��6(     TextBoxStyle#��[ 5      
 �� 	MaxLength$
 30��5!      ��5       ��   TextBox_Template �� Source# [ 5!      �� 5#   
   -   5        $ PasswordLabel��5#      $��2��6'   $��Password��64   #��[  6G   �� 5$   
   -   5        $	 PasswordTextBox��5$      $��3��6+   $��50��5%      #��[ 6   $
 30��5'      ��5&      �� # [ 5'      �� 5)   
   -   5         ��Name$ LogInButton��5)      $��4��6&   $��
Войти��63     ButtonStyle#��[ 6C   ��6h   ��   Button_Template# [ �� 5*   
   -   5        $ RegistrationButton��5*      $��110 10 10 10q�6-   $��1��6C   $��5��6S   $��Регистрация��6`   #��[ 6v   ��6�   �� # [ 5+      5,      