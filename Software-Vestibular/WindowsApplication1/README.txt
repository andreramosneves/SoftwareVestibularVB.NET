Depois de instalar o driver ODBC da Oracle e ao entrar na op��o Painel de Controle / Ferramentas Administrativas / Fontes de Dados (ODBC) e adicionar uma nova fonte de dados n�o aparecia o Driver da Oracle. 
Como muita pesquisa no Google descobri que a vers�o que instalei do Oracle 11g � apenas para 32bits e o meu sistema operacional � 64bits.

Ent�o a solu��o � executar a ferramenta de fontes de dados em 32bits atrav�s do atalho:  Iniciar/Executar %systemdrive%\Windows\SysWoW64\Odbcad32.exe

INSTALAR O SQL SERVER 2012