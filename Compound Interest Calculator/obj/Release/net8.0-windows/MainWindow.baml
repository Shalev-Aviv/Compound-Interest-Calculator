   M S B A M L   `   `   `  ���� W  SCompound Interest Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Compound_Interest_CalculatorCompound_Interest_Calculator  -    'Compound_Interest_Calculator.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:Compound_Interest_Calculator       � Title$  Compound Calculator��$	��600��$	��350��$	��600��$	��350�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName   main �� Color  	secondery��%f  '��       '��      &	      &	 +    �� " ��.���  � �� �� " ��.R��� $ border��#��z��#��z��$��2q�$ 5��._��� $ PART_ContentHost��$��10,0,0,0q�$��Center=�$��0q�	 P� 
 � {�$ False��. ��� $ border��# � �� � ���� $ border��# � �� � ���� " ��.���  � �� �� " ��.R��� $ border��#��z��#��z��$��2q�$ 5��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver$
 True��. ��� $ border�� � �� �#304f2aP� 
 � ��$
 True��. ��� $ border�� � �� �#3D6734P� 
 � {�$ False��. ��� $ border�� � �� �#CCCCCC�� $ border�� � �� �#3D6734��  � �� �#888888��  � �� �#3D6734��  � ��
 �������  � ��$
 Bold"���  � ��$ 35����  � ��$	 100���� $ #3D6734���� $ #3D6734��.���  � ColumnDefinitions �� $
��15px ��� $	��80* ��� $
��15px �.+��� $��Compound Calculator��$��1��$��Center=�$	��Top=�$��21(�$
��Bold"�$��0,20,0,0q�#��[  �� $��Stretch=�$��1��$	��Top=�$��0,70,0,0q�.+��� -    ��Name$ InitialDeposit��$��Initial deposit��$
��0,10q�$��35��$��14(�#��[ $��2q�#��[ �� -   $ MonthlyDeposit��$��Monthly deposit��$
��0,10q�$��35��$��14(�#��[ $��2q�#��[ �� -   $ AnnualInterest��$��Annual interest��$
��0,10q�$��35��$��14(�#��[ $��2q�#��[ �� -   $ YearsOfInvestment��$��Years of investment��$
��0,10q�$��35��$��14(�#��[ $��2q�#��[ �� -   $��	Calculate��$	��Top=�$
��Left=�$��
13,300,0,0q�$	��100��$��35��#��[  
�������$��14(�
������ $
��Bold"�$��2���� -   $��Reset��$��1��$	��Top=�$��Right=�$��	0,300,0,0q�$	��100��$��35��
�������#��[  #��[  $��2q�$��14(�$
��Bold"��� $��1��$��Center=�$	��Top=�$��	0,400,0,0q�$y�Visible=� J� Opacity$	 100Q�$|�False��$
��auto��.+��� -   $��TotalDepositTextBlock�� �� 
IsReadOnly$
 True��$��0q�
������ #��[  $��14(�$
��Bold"�$	��0,5q� � FocusVisualStyle Z� . �/� .T�J�  �� TextAlignment$
 Left=�.*�Total deposit: 0.00�� -   $��ProfitTextBlock��$
 True��$��0q�
������ #��[  $��14(�$
��Bold"�$	��0,5q� Z� . �/� .T�J� $
 Left=�.*�Profit: 0.00�� -	   $$��AccumulatedInvestmentTextBlock��$
 True��$��0q�
������ #��[  $��14(�$
��Bold"�$	��0,5q� Z� . �/� .T�J� $
 Left=�.*�Accumulated investment: 0.00