SELECT C.NOMECLIENTE AS NOME_CLIENTE,
       p.produtoid AS NR_PEDIDO,
       p.datapedido AS DT_PEDIDO FROM PEDIDOS P

INNER JOIN clientes C
ON C.CLIENTEID = p.clienteid

ORDER BY p.datapedido DESC  

