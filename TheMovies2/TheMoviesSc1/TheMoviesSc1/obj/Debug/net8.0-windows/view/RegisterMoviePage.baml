   M S B A M L   `   `   `  ����G  CTheMoviesSc1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TheMoviesSc1.ViewTheMoviesSc1.View  5      )    #TheMoviesSc1.View.RegisterMoviePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TheMoviesSc1.View     5        N� Title$  RegisterMoviePage��5	      .��5      � .+�5   
   � $��1��6   $��20,0,0,0q�6   $��Center=�61   $
��Left=�6L    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��62   $
��0,10q�6?   .+�5      �� $��Title:��6   $	��100��6)   $��Center=�65   �� 5      -   5         ��Name$ TitleTextBox��5      $	��200��61   $
��10,0q�6=   5      �� 5"      $ 
Horizontal=�6   $��1��62   $
��0,10q�6?   .+�5#      �� $��Genre:��6   $	��100��6)   $��Center=�65   �� 5$      -   5        $ GenreTextBox��5$      $	��200��61   $
��10,0q�6=   5%      �� 5(      $ 
Horizontal=�6   $��2��62   $
��0,10q�6?   .+�5)      �� $��	Duration:��6   $	��100��6,   $��Center=�68   �� 5*      -   5        $ DurationTextBox��5*      $	��200��64   $
��10,0q�6@   5+      �� 5.      $ 
Horizontal=�6   $��3��62   $��20,10q�6?   .+�5/      �� -   5        $��Add Film��5/      $	��100��6,   68   �� 50      -   5        $��Clear��50      $	��100��6)   $
��10,0q�65   6C   51      53      &   System.Windows.Controls.DataGrid  54   
   -   5          Name$ MoviesDataGrid��54         AutoGenerateColumns$
 True��6+   $��396,47,34,47q�6F   6\   55      56      