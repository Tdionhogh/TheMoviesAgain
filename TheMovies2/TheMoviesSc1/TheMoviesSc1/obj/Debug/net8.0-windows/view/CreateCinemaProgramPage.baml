   M S B A M L   `   `   `  ����G  CTheMoviesSc1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TheMoviesSc1.ViewTheMoviesSc1.View  5      /    )TheMoviesSc1.View.CreateCinemaProgramPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TheMoviesSc1.View     5        N� Title$  CreateCinemaProgramPage��5	      .��5      � .+�5   
   �� $��Title��6   $
��Left=�6    $��	45,43,0,0q�6;   $	��Top=�6N   $��96��6f   �� 5   
   $��Genre��6   $
��Left=�6    $��	45,92,0,0q�6;   $	��Top=�6N   $	��120��6f   �� 5   
   $��	Play time��6   $
��Left=�6$   $��
44,286,0,0q�6?   $	��Top=�6S   $	��140��6k   �� 5   
   $��Duration��6   $
��Left=�6#   $��
45,139,0,0q�6>   $	��Top=�6R   $	��116��6j   �� 5   
   $��Producer��6   $
��Left=�6#   $��
52,414,0,0q�6>   $	��Top=�6R   $	��125��6j   �� 5   
   $��Premiere date��6   $
��Left=�6(   $��	4,329,0,0q�6C   $	��Top=�6V   $��96��6n   �� 5   
   $
��Hall��6   $
��Left=�6   $��
45,239,0,0q�6:   $	��Top=�6N   $��90��6f   �� 5   
   -   5         ��Name$ Title��5      $
��Left=�6!   $��
116,47,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $ Genre��5      $
��Left=�6!   $��
116,96,0,0q�6<   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $ PlayingTime��5      $
��Left=�6'   $��116,290,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ Duration��5      $
��Left=�6$   $��117,143,0,0q�6?   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $ Director��5      $
��Left=�6$   $��116,418,0,0q�6?   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $ Screen��5      $
��Left=�6"   $��117,243,0,0q�6=   $
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��120��6�   �� 5   
   -   5        $ PremiereDate��5      $
��Left=�6(   $��117,333,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $��Clear��5      $
��Left=�6!   $��259,143,0,0q�6<   $	��Top=�6Q   6i   �� 5   
   -	   5        $
��Save��5      $
��Left=�6    $��261,284,0,0q�6;   $	��Top=�6P    J� RenderTransformOrigin$ 0.693,2.004&�6�   �� 5   
   $��Cinema��6   $
��Left=�6!   $��
45,190,0,0q�6<   $	��Top=�6P   $	��110��6h   �� 5   
   -
   5        $ MovieTheater��5      $
��Left=�6(   $��117,194,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   �� 5   
   $
��City��6   $
��Left=�6   $��
52,372,0,0q�6:   $	��Top=�6N   �� 5   
   -   5        $
 City��5      $
��Left=�6    $��117,376,0,0q�6;   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ MoviesDataGridFull��5          AutoGenerateColumns$
 True��6/   $��396,47,34,47q�6J   6`   5!      5"      