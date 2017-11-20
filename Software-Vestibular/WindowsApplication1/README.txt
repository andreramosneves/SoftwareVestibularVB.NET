Depois de instalar o driver ODBC da Oracle e ao entrar na opção Painel de Controle / Ferramentas Administrativas / Fontes de Dados (ODBC) e adicionar uma nova fonte de dados não aparecia o Driver da Oracle. 
Como muita pesquisa no Google descobri que a versão que instalei do Oracle 11g é apenas para 32bits e o meu sistema operacional é 64bits.

Então a solução é executar a ferramenta de fontes de dados em 32bits através do atalho:  Iniciar/Executar %systemdrive%\Windows\SysWoW64\Odbcad32.exe

INSTALAR O SQL SERVER 2012