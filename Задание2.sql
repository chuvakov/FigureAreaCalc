{\rtf1\ansi\ansicpg1251\cocoartf2639
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fnil\fcharset0 Menlo-Bold;\f1\fnil\fcharset0 Menlo-Regular;}
{\colortbl;\red255\green255\blue255;\red115\green158\blue202;\red170\green170\blue170;\red158\green158\blue158;
\red238\green204\blue100;}
{\*\expandedcolortbl;;\csgenericrgb\c45098\c61961\c79216;\csgenericrgb\c66667\c66667\c66667;\csgenericrgb\c61961\c61961\c61961;
\csgenericrgb\c93333\c80000\c39216;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\partightenfactor0

\f0\b\fs24 \cf2 select
\f1\b0 \cf3  \cf4 p\cf3 .\cf4 product\cf3 , \cf4 c\cf3 .\cf4 category\cf3  \cf0 \

\f0\b \cf2 from
\f1\b0 \cf3  \cf4 products\cf3  
\f0\b \cf2 as
\f1\b0 \cf3  \cf4 p\cf3  \cf0 \

\f0\b \cf2 left
\f1\b0 \cf3  
\f0\b \cf2 join
\f1\b0 \cf3  \cf4 productscategories\cf3  
\f0\b \cf2 as
\f1\b0 \cf3  \cf4 pc\cf3  
\f0\b \cf2 on
\f1\b0 \cf3  \cf4 p\cf3 .\cf4 id\cf3  = \cf4 pc\cf3 .\cf4 productid\cf3  \cf0 \

\f0\b \cf2 left
\f1\b0 \cf3  
\f0\b \cf2 join
\f1\b0 \cf3  \cf4 category\cf3  
\f0\b \cf2 as
\f1\b0 \cf3  \cf4 c\cf3  
\f0\b \cf2 on
\f1\b0 \cf3  \cf4 pc\cf3 .\cf4 categoryid\cf3  = \cf4 c\cf3 .\cf4 id\cf5 ;}