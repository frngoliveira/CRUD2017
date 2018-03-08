angular.module("Crud2017App.controllers", []).
    controller("IniCtrl", function ($scope, Service, $location) {

        $scope.message = "Controle de Início";

        var r = Service.GetAllPrg();
        console.log(r);
        r.then(function (result) {
            $scope.progs = result.data;
            console.log();
        });

        $scope.Delprogms = function (prog) {
            var conf = confirm("Tem certeza da exclusão dos dados, isso será irreversível");
            if (conf)
            {
                $scope.progs.splice(prog, 1);
                Service.DeletarPrg(prog);
                location.reload();
            }
            else
            {
                return false;
                location.reload();
            }                 
        }
    }).
    controller("AddCtrl", function ($scope, Service, $location) {
        $scope.msg = "Adcionar Programers";
        $scope.msgcon = "Nível de Conhecimento";
        $scope.dbanc = "Dados Bancário";
        $scope.Ender = "Adicionar Endereço";
                
        $scope.AddCC = function()
        {            
            Service.AddProg($scope.programers, $scope.conhec, $scope.dban, $scope.end);
            alert("Dados incluído com sucesso na Base de Dados")
            delete $scope.programers;
            delete $scope.conhec;
            delete $scope.dban;
            delete $scope.end;
            location.reload();
        }
    }).
    controller("EditCtrl", function ($scope, Service, $routeParams, $location) {
        $scope.msg = "Editar Dados";
        $scope.msgProg = "Editar Programador";
        $scope.msgConhe = "Editar Conhecimento";
        $scope.msgDBanc = "Editar Dados Bancários";
        $scope.msgEnder = "Editar Endereço";

        var id = $routeParams.id;
        Service.GetById(id).
            then(function (d) {
                if (d.data.pcbe != null)
                {
                    $scope.prg = d.data.pcbe;
                    $scope.con = d.data.pcbe;
                    $scope.db = d.data.pcbe;
                    $scope.en = d.data.pcbe;                    
                }                
            });
        $scope.EditProg = function ()
        {            
            Service.UpdateProg($scope.prg, $scope.con, $scope.db, $scope.en )
            alert("Dados Atualizados com sucesso!");
        }
    }).
    controller("DetailsCtrl", function ($scope, Service) {
        $scope.msg = "Adcionar Programers";
    }).
    
factory("Service", ["$http", function ($http) {
    var fab = {};

    fab.GetAllPrg = function ()
    {
        return $http.get("/Conhecimento/GetAllProgram");
    }
    fab.AddProg = function (programers, conhec, dban, end)
    {
        $http.post("/Conhecimento/AddProg/", { programers, conhec, dban, end });
    }
    fab.DeletarPrg = function (prog) {
        $http.post("/Conhecimento/DelProg/", { prog });
    }
    fab.GetById = function (id) {
        return $http.get("/Conhecimento/GetById", { params: { id: id } });
    }
    fab.UpdateProg = function (prg, con, db, en)
    {  
        $http.post("/Conhecimento/UpdateProg/", { prg, con, db, en});
    }    
    return fab;
}])