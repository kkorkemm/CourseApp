   M S B A M L   `   `   `  ����D  @CourseApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CourseApp.PagesCourseApp.Pages  5      9!clr-namespace:CourseApp.ViewModelCourseApp.ViewModel  5          CourseApp.Pages.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CourseApp.Pages     5      7	viewModel!clr-namespace:CourseApp.ViewModel     5        N� Title$  	AdminPage��5
       � DataContext 5      '  !CourseApp.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��0.15* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��0.25* �6   �� 5      .+�5   
   � ���#223$��2��6!   �� 5   
   $)��#Управление курсами��6      H1#��[  5      
�������$��1��5       $��10q�5!      $
��Left=�5"      � 5$   
   ���#eee$��1��5%       5&      �� 5'      $
��auto �6    �� 5(      �� 5)      $
��auto �6    .+�5,      �� -   5         ��Name$ 	TextHello��5-      $'��!Добро пожаловать, ��5,      $��10 20 10 20q�5.      $��Center=�5/      $��Center=�50      $
��Wrap=�51       �� TextAlignment$ Center=�52      $��SemiBold"�53      $��16(�54      �� 56      $��1��6   .+�57      	� $��
Курсы��6     
MenuButton#��[ 58       d� 	IsChecked$
 TrueY�5:      $��50��5;      ��59      �� *AdminCourseCommand+5;      	� 5<      $��Студенты��6   #��[ 5=      $��50��5?      ��5>      �� *AdminUsersCommand+5?      	� 5@      $��Настройки��6   #��[ 5A      $��50��5C      ��5B      �� *AdminSettingsCommand+5C      5D      �� 5F      -   5         ��Name$ BtnExit��5F      $��2��5G      $��10q�5H      $��
Выйти��5I        GreenButton#��[ 5J      5K      5M      �� 5O   
   $��20q�6   $��1��5P      $��1��5Q      ��5R      �� *CurrentView+5T      5U      