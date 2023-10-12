﻿using System.Runtime.CompilerServices;
using MementoMori.Ortega.Share.Data.DtoInfo;
using MessagePack;

namespace MementoMori.Ortega.Share.Data.ApiInterface.DungeonBattle;

[MessagePackObject(true)]
public class UseRecoveryItemResponse : ApiResponseBase, IUserSyncApiResponse
{
    public List<UserDungeonBattleCharacterDtoInfo> UserDungeonBattleCharacterDtoInfos { get; set; }

    public UserDungeonBattleDtoInfo UserDungeonBattleDtoInfo { get; set; }

    public UserSyncData UserSyncData { get; set; }
}