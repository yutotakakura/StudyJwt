FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /App/

RUN dotnet dev-certs https

# CMD ["dotnet", "run", "--urls http://\*:5000"]
# ToDo:上のCMDが実行できなくて、下のCMDが実行できる原因を調べる
CMD dotnet run --urls http://\*:5000