# Laboratory Control
Repositório destinada à cadeira de Projeto Integrador III.

# Figma
[Link do figma](https://www.figma.com/file/W1Eo6fM6IcUvCbVwomsApz/Laboratory-Control?type=design&node-id=0-1&mode=design&t=vvdwZbHmEQLEA02V-0)

# Arquitetura do projeto
![image](https://github.com/reinaldosales/laboratory-control/assets/86421180/7814f94c-8f10-4d59-a5d3-ad568ff10f25)

# CLI necessário

dotnet ef migrations add Initial --project LaboratoryControl.Infra.Data -s LaboratoryControl.BlazorApp -c ApplicationDbContext --verbose

dotnet ef database update Initial --project LaboratoryControl.Infra.Data -s LaboratoryControl.BlazorApp -c ApplicationDbContext --verbose
