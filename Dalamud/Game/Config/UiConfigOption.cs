﻿namespace Dalamud.Game.Config;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

/// <summary>
/// Config options in the UiConfig section.
/// </summary>
public enum UiConfigOption
{
    /// <summary>
    /// UiConfig option with the internal name BattleEffectSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BattleEffectSelf", ConfigType.UInt)]
    BattleEffectSelf,

    /// <summary>
    /// UiConfig option with the internal name BattleEffectParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BattleEffectParty", ConfigType.UInt)]
    BattleEffectParty,

    /// <summary>
    /// UiConfig option with the internal name BattleEffectOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BattleEffectOther", ConfigType.UInt)]
    BattleEffectOther,

    /// <summary>
    /// UiConfig option with the internal name BattleEffectPvPEnemyPc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BattleEffectPvPEnemyPc", ConfigType.UInt)]
    BattleEffectPvPEnemyPc,

    /// <summary>
    /// UiConfig option with the internal name PadMode.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PadMode", ConfigType.UInt)]
    PadMode,

    /// <summary>
    /// UiConfig option with the internal name WeaponAutoPutAway.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("WeaponAutoPutAway", ConfigType.UInt)]
    WeaponAutoPutAway,

    /// <summary>
    /// UiConfig option with the internal name WeaponAutoPutAwayTime.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("WeaponAutoPutAwayTime", ConfigType.UInt)]
    WeaponAutoPutAwayTime,

    /// <summary>
    /// UiConfig option with the internal name LipMotionType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LipMotionType", ConfigType.UInt)]
    LipMotionType,

    /// <summary>
    /// UiConfig option with the internal name FirstPersonDefaultYAngle.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("FirstPersonDefaultYAngle", ConfigType.Float)]
    FirstPersonDefaultYAngle,

    /// <summary>
    /// UiConfig option with the internal name FirstPersonDefaultZoom.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("FirstPersonDefaultZoom", ConfigType.Float)]
    FirstPersonDefaultZoom,

    /// <summary>
    /// UiConfig option with the internal name FirstPersonDefaultDistance.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("FirstPersonDefaultDistance", ConfigType.Float)]
    FirstPersonDefaultDistance,

    /// <summary>
    /// UiConfig option with the internal name ThirdPersonDefaultYAngle.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("ThirdPersonDefaultYAngle", ConfigType.Float)]
    ThirdPersonDefaultYAngle,

    /// <summary>
    /// UiConfig option with the internal name ThirdPersonDefaultZoom.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("ThirdPersonDefaultZoom", ConfigType.Float)]
    ThirdPersonDefaultZoom,

    /// <summary>
    /// UiConfig option with the internal name ThirdPersonDefaultDistance.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("ThirdPersonDefaultDistance", ConfigType.Float)]
    ThirdPersonDefaultDistance,

    /// <summary>
    /// UiConfig option with the internal name LockonDefaultYAngle.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("LockonDefaultYAngle", ConfigType.Float)]
    LockonDefaultYAngle,

    /// <summary>
    /// UiConfig option with the internal name LockonDefaultZoom.
    /// This option is a Float.
    /// </summary>
    [GameConfigOption("LockonDefaultZoom", ConfigType.Float)]
    LockonDefaultZoom,

    /// <summary>
    /// UiConfig option with the internal name CameraProductionOfAction.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CameraProductionOfAction", ConfigType.UInt)]
    CameraProductionOfAction,

    /// <summary>
    /// UiConfig option with the internal name FPSCameraInterpolationType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FPSCameraInterpolationType", ConfigType.UInt)]
    FPSCameraInterpolationType,

    /// <summary>
    /// UiConfig option with the internal name FPSCameraVerticalInterpolation.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FPSCameraVerticalInterpolation", ConfigType.UInt)]
    FPSCameraVerticalInterpolation,

    /// <summary>
    /// UiConfig option with the internal name LegacyCameraCorrectionFix.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LegacyCameraCorrectionFix", ConfigType.UInt)]
    LegacyCameraCorrectionFix,

    /// <summary>
    /// UiConfig option with the internal name LegacyCameraType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LegacyCameraType", ConfigType.UInt)]
    LegacyCameraType,

    /// <summary>
    /// UiConfig option with the internal name EventCameraAutoControl.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EventCameraAutoControl", ConfigType.UInt)]
    EventCameraAutoControl,

    /// <summary>
    /// UiConfig option with the internal name CameraLookBlinkType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CameraLookBlinkType", ConfigType.UInt)]
    CameraLookBlinkType,

    /// <summary>
    /// UiConfig option with the internal name IdleEmoteTime.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IdleEmoteTime", ConfigType.UInt)]
    IdleEmoteTime,

    /// <summary>
    /// UiConfig option with the internal name IdleEmoteRandomType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IdleEmoteRandomType", ConfigType.UInt)]
    IdleEmoteRandomType,

    /// <summary>
    /// UiConfig option with the internal name CutsceneSkipIsShip.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CutsceneSkipIsShip", ConfigType.UInt)]
    CutsceneSkipIsShip,

    /// <summary>
    /// UiConfig option with the internal name CutsceneSkipIsContents.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CutsceneSkipIsContents", ConfigType.UInt)]
    CutsceneSkipIsContents,

    /// <summary>
    /// UiConfig option with the internal name CutsceneSkipIsHousing.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CutsceneSkipIsHousing", ConfigType.UInt)]
    CutsceneSkipIsHousing,

    /// <summary>
    /// UiConfig option with the internal name PetTargetOffInCombat.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PetTargetOffInCombat", ConfigType.UInt)]
    PetTargetOffInCombat,

    /// <summary>
    /// UiConfig option with the internal name GroundTargetFPSPosX.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GroundTargetFPSPosX", ConfigType.UInt)]
    GroundTargetFPSPosX,

    /// <summary>
    /// UiConfig option with the internal name GroundTargetFPSPosY.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GroundTargetFPSPosY", ConfigType.UInt)]
    GroundTargetFPSPosY,

    /// <summary>
    /// UiConfig option with the internal name GroundTargetTPSPosX.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GroundTargetTPSPosX", ConfigType.UInt)]
    GroundTargetTPSPosX,

    /// <summary>
    /// UiConfig option with the internal name GroundTargetTPSPosY.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GroundTargetTPSPosY", ConfigType.UInt)]
    GroundTargetTPSPosY,

    /// <summary>
    /// UiConfig option with the internal name TargetDisableAnchor.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TargetDisableAnchor", ConfigType.UInt)]
    TargetDisableAnchor,

    /// <summary>
    /// UiConfig option with the internal name TargetCircleClickFilterEnableNearestCursor.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TargetCircleClickFilterEnableNearestCursor", ConfigType.UInt)]
    TargetCircleClickFilterEnableNearestCursor,

    /// <summary>
    /// UiConfig option with the internal name TargetEnableMouseOverSelect.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TargetEnableMouseOverSelect", ConfigType.UInt)]
    TargetEnableMouseOverSelect,

    /// <summary>
    /// UiConfig option with the internal name GroundTargetCursorCorrectType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GroundTargetCursorCorrectType", ConfigType.UInt)]
    GroundTargetCursorCorrectType,

    /// <summary>
    /// UiConfig option with the internal name GroundTargetActionExcuteType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GroundTargetActionExcuteType", ConfigType.UInt)]
    GroundTargetActionExcuteType,

    /// <summary>
    /// UiConfig option with the internal name AutoNearestTarget.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("AutoNearestTarget", ConfigType.UInt)]
    AutoNearestTarget,

    /// <summary>
    /// UiConfig option with the internal name AutoNearestTargetType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("AutoNearestTargetType", ConfigType.UInt)]
    AutoNearestTargetType,

    /// <summary>
    /// UiConfig option with the internal name RightClickExclusionPC.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("RightClickExclusionPC", ConfigType.UInt)]
    RightClickExclusionPC,

    /// <summary>
    /// UiConfig option with the internal name RightClickExclusionBNPC.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("RightClickExclusionBNPC", ConfigType.UInt)]
    RightClickExclusionBNPC,

    /// <summary>
    /// UiConfig option with the internal name RightClickExclusionMinion.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("RightClickExclusionMinion", ConfigType.UInt)]
    RightClickExclusionMinion,

    /// <summary>
    /// UiConfig option with the internal name EnableMoveTiltCharacter.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EnableMoveTiltCharacter", ConfigType.UInt)]
    EnableMoveTiltCharacter,

    /// <summary>
    /// UiConfig option with the internal name EnableMoveTiltMountGround.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EnableMoveTiltMountGround", ConfigType.UInt)]
    EnableMoveTiltMountGround,

    /// <summary>
    /// UiConfig option with the internal name EnableMoveTiltMountFly.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EnableMoveTiltMountFly", ConfigType.UInt)]
    EnableMoveTiltMountFly,

    /// <summary>
    /// UiConfig option with the internal name TurnSpeed.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TurnSpeed", ConfigType.UInt)]
    TurnSpeed,

    /// <summary>
    /// UiConfig option with the internal name FootEffect.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FootEffect", ConfigType.UInt)]
    FootEffect,

    /// <summary>
    /// UiConfig option with the internal name LegacySeal.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LegacySeal", ConfigType.UInt)]
    LegacySeal,

    /// <summary>
    /// UiConfig option with the internal name GBarrelDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GBarrelDisp", ConfigType.UInt)]
    GBarrelDisp,

    /// <summary>
    /// UiConfig option with the internal name EgiMirageTypeGaruda.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EgiMirageTypeGaruda", ConfigType.UInt)]
    EgiMirageTypeGaruda,

    /// <summary>
    /// UiConfig option with the internal name EgiMirageTypeTitan.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EgiMirageTypeTitan", ConfigType.UInt)]
    EgiMirageTypeTitan,

    /// <summary>
    /// UiConfig option with the internal name EgiMirageTypeIfrit.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EgiMirageTypeIfrit", ConfigType.UInt)]
    EgiMirageTypeIfrit,

    /// <summary>
    /// UiConfig option with the internal name BahamutSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BahamutSize", ConfigType.UInt)]
    BahamutSize,

    /// <summary>
    /// UiConfig option with the internal name PetMirageTypeCarbuncleSupport.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PetMirageTypeCarbuncleSupport", ConfigType.UInt)]
    PetMirageTypeCarbuncleSupport,

    /// <summary>
    /// UiConfig option with the internal name PhoenixSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PhoenixSize", ConfigType.UInt)]
    PhoenixSize,

    /// <summary>
    /// UiConfig option with the internal name GarudaSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GarudaSize", ConfigType.UInt)]
    GarudaSize,

    /// <summary>
    /// UiConfig option with the internal name TitanSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TitanSize", ConfigType.UInt)]
    TitanSize,

    /// <summary>
    /// UiConfig option with the internal name IfritSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IfritSize", ConfigType.UInt)]
    IfritSize,

    /// <summary>
    /// UiConfig option with the internal name SolBahamutSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("SolBahamutSize", ConfigType.UInt)]
    SolBahamutSize,

    /// <summary>
    /// UiConfig option with the internal name PetMirageTypeFairy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PetMirageTypeFairy", ConfigType.UInt)]
    PetMirageTypeFairy,

    /// <summary>
    /// UiConfig option with the internal name TimeMode.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TimeMode", ConfigType.UInt)]
    TimeMode,

    /// <summary>
    /// UiConfig option with the internal name Time12.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("Time12", ConfigType.UInt)]
    Time12,

    /// <summary>
    /// UiConfig option with the internal name TimeEorzea.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TimeEorzea", ConfigType.UInt)]
    TimeEorzea,

    /// <summary>
    /// UiConfig option with the internal name TimeLocal.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TimeLocal", ConfigType.UInt)]
    TimeLocal,

    /// <summary>
    /// UiConfig option with the internal name TimeServer.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TimeServer", ConfigType.UInt)]
    TimeServer,

    /// <summary>
    /// UiConfig option with the internal name ActiveLS_H.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ActiveLS_H", ConfigType.UInt)]
    ActiveLS_H,

    /// <summary>
    /// UiConfig option with the internal name ActiveLS_L.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ActiveLS_L", ConfigType.UInt)]
    ActiveLS_L,

    /// <summary>
    /// UiConfig option with the internal name HotbarLock.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarLock", ConfigType.UInt)]
    HotbarLock,

    /// <summary>
    /// UiConfig option with the internal name HotbarDispRecastTime.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarDispRecastTime", ConfigType.UInt)]
    HotbarDispRecastTime,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossContentsActionEnableInput.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossContentsActionEnableInput", ConfigType.UInt)]
    HotbarCrossContentsActionEnableInput,

    /// <summary>
    /// UiConfig option with the internal name HotbarDispRecastTimeDispType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarDispRecastTimeDispType", ConfigType.UInt)]
    HotbarDispRecastTimeDispType,

    /// <summary>
    /// UiConfig option with the internal name ExHotbarChangeHotbar1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ExHotbarChangeHotbar1", ConfigType.UInt)]
    ExHotbarChangeHotbar1,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon01.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon01", ConfigType.UInt)]
    HotbarCommon01,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon02.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon02", ConfigType.UInt)]
    HotbarCommon02,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon03.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon03", ConfigType.UInt)]
    HotbarCommon03,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon04.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon04", ConfigType.UInt)]
    HotbarCommon04,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon05.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon05", ConfigType.UInt)]
    HotbarCommon05,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon06.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon06", ConfigType.UInt)]
    HotbarCommon06,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon07.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon07", ConfigType.UInt)]
    HotbarCommon07,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon08.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon08", ConfigType.UInt)]
    HotbarCommon08,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon09.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon09", ConfigType.UInt)]
    HotbarCommon09,

    /// <summary>
    /// UiConfig option with the internal name HotbarCommon10.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCommon10", ConfigType.UInt)]
    HotbarCommon10,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon01.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon01", ConfigType.UInt)]
    HotbarCrossCommon01,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon02.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon02", ConfigType.UInt)]
    HotbarCrossCommon02,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon03.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon03", ConfigType.UInt)]
    HotbarCrossCommon03,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon04.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon04", ConfigType.UInt)]
    HotbarCrossCommon04,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon05.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon05", ConfigType.UInt)]
    HotbarCrossCommon05,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon06.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon06", ConfigType.UInt)]
    HotbarCrossCommon06,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon07.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon07", ConfigType.UInt)]
    HotbarCrossCommon07,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossCommon08.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossCommon08", ConfigType.UInt)]
    HotbarCrossCommon08,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossHelpDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossHelpDisp", ConfigType.UInt)]
    HotbarCrossHelpDisp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossOperation.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossOperation", ConfigType.UInt)]
    HotbarCrossOperation,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossDisp", ConfigType.UInt)]
    HotbarCrossDisp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossLock.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossLock", ConfigType.UInt)]
    HotbarCrossLock,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossUsePadGuide.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossUsePadGuide", ConfigType.UInt)]
    HotbarCrossUsePadGuide,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossActiveSet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossActiveSet", ConfigType.UInt)]
    HotbarCrossActiveSet,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossActiveSetPvP.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossActiveSetPvP", ConfigType.UInt)]
    HotbarCrossActiveSetPvP,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsAuto.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsAuto", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsAuto,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustom.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustom", ConfigType.UInt)]
    HotbarCrossSetChangeCustom,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet1", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet1,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet2", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet2,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet3", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet3,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet4", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet4,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet5", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet5,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet6", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet6,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet7", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet7,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet8", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet8,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSword.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSword", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSword,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet1", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet1,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet2", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet2,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet3", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet3,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet4", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet4,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet5", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet5,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet6", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet6,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet7", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet7,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet8", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet8,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossAdvancedSetting.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossAdvancedSetting", ConfigType.UInt)]
    HotbarCrossAdvancedSetting,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossAdvancedSettingLeft.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossAdvancedSettingLeft", ConfigType.UInt)]
    HotbarCrossAdvancedSettingLeft,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossAdvancedSettingRight.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossAdvancedSettingRight", ConfigType.UInt)]
    HotbarCrossAdvancedSettingRight,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetPvpModeActive.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetPvpModeActive", ConfigType.UInt)]
    HotbarCrossSetPvpModeActive,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomPvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomPvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomPvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsAutoPvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsAutoPvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsAutoPvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet1Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet1Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet1Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet2Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet2Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet2Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet3Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet3Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet3Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet4Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet4Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet4Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet5Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet5Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet5Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet6Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet6Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet6Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet7Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet7Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet7Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomSet8Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomSet8Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomSet8Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordPvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordPvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordPvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet1Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet1Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet1Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet2Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet2Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet2Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet3Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet3Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet3Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet4Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet4Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet4Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet5Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet5Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet5Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet6Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet6Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet6Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet7Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet7Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet7Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossSetChangeCustomIsSwordSet8Pvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossSetChangeCustomIsSwordSet8Pvp", ConfigType.UInt)]
    HotbarCrossSetChangeCustomIsSwordSet8Pvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossAdvancedSettingPvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossAdvancedSettingPvp", ConfigType.UInt)]
    HotbarCrossAdvancedSettingPvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossAdvancedSettingLeftPvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossAdvancedSettingLeftPvp", ConfigType.UInt)]
    HotbarCrossAdvancedSettingLeftPvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossAdvancedSettingRightPvp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossAdvancedSettingRightPvp", ConfigType.UInt)]
    HotbarCrossAdvancedSettingRightPvp,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBEnable.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBEnable", ConfigType.UInt)]
    HotbarWXHBEnable,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBSetLeft.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBSetLeft", ConfigType.UInt)]
    HotbarWXHBSetLeft,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBSetRight.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBSetRight", ConfigType.UInt)]
    HotbarWXHBSetRight,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBEnablePvP.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBEnablePvP", ConfigType.UInt)]
    HotbarWXHBEnablePvP,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBSetLeftPvP.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBSetLeftPvP", ConfigType.UInt)]
    HotbarWXHBSetLeftPvP,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBSetRightPvP.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBSetRightPvP", ConfigType.UInt)]
    HotbarWXHBSetRightPvP,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHB8Button.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHB8Button", ConfigType.UInt)]
    HotbarWXHB8Button,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHB8ButtonPvP.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHB8ButtonPvP", ConfigType.UInt)]
    HotbarWXHB8ButtonPvP,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBSetInputTime.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBSetInputTime", ConfigType.UInt)]
    HotbarWXHBSetInputTime,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBDisplay.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBDisplay", ConfigType.UInt)]
    HotbarWXHBDisplay,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBFreeLayout.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBFreeLayout", ConfigType.UInt)]
    HotbarWXHBFreeLayout,

    /// <summary>
    /// UiConfig option with the internal name HotbarXHBActiveTransmissionAlpha.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarXHBActiveTransmissionAlpha", ConfigType.UInt)]
    HotbarXHBActiveTransmissionAlpha,

    /// <summary>
    /// UiConfig option with the internal name HotbarXHBAlphaDefault.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarXHBAlphaDefault", ConfigType.UInt)]
    HotbarXHBAlphaDefault,

    /// <summary>
    /// UiConfig option with the internal name HotbarXHBAlphaActiveSet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarXHBAlphaActiveSet", ConfigType.UInt)]
    HotbarXHBAlphaActiveSet,

    /// <summary>
    /// UiConfig option with the internal name HotbarXHBAlphaInactiveSet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarXHBAlphaInactiveSet", ConfigType.UInt)]
    HotbarXHBAlphaInactiveSet,

    /// <summary>
    /// UiConfig option with the internal name HotbarWXHBInputOnce.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarWXHBInputOnce", ConfigType.UInt)]
    HotbarWXHBInputOnce,

    /// <summary>
    /// UiConfig option with the internal name ExHotbarChangeHotbar1IsFashion.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ExHotbarChangeHotbar1IsFashion", ConfigType.UInt)]
    ExHotbarChangeHotbar1IsFashion,

    /// <summary>
    /// UiConfig option with the internal name HotbarCrossUseExDirectionAutoSwitch.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarCrossUseExDirectionAutoSwitch", ConfigType.UInt)]
    HotbarCrossUseExDirectionAutoSwitch,

    /// <summary>
    /// UiConfig option with the internal name IdlingCameraSwitchType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IdlingCameraSwitchType", ConfigType.UInt)]
    IdlingCameraSwitchType,

    /// <summary>
    /// UiConfig option with the internal name HotbarXHBEditEnable.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarXHBEditEnable", ConfigType.UInt)]
    HotbarXHBEditEnable,

    /// <summary>
    /// UiConfig option with the internal name HotbarContentsAction2ReverseOperation.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarContentsAction2ReverseOperation", ConfigType.UInt)]
    HotbarContentsAction2ReverseOperation,

    /// <summary>
    /// UiConfig option with the internal name HotbarContentsAction2ReturnInitialSlot.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarContentsAction2ReturnInitialSlot", ConfigType.UInt)]
    HotbarContentsAction2ReturnInitialSlot,

    /// <summary>
    /// UiConfig option with the internal name HotbarContentsAction2ReverseRotate.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HotbarContentsAction2ReverseRotate", ConfigType.UInt)]
    HotbarContentsAction2ReverseRotate,

    /// <summary>
    /// UiConfig option with the internal name PlateType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PlateType", ConfigType.UInt)]
    PlateType,

    /// <summary>
    /// UiConfig option with the internal name PlateDispHPBar.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PlateDispHPBar", ConfigType.UInt)]
    PlateDispHPBar,

    /// <summary>
    /// UiConfig option with the internal name PlateDisableMaxHPBar.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PlateDisableMaxHPBar", ConfigType.UInt)]
    PlateDisableMaxHPBar,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpSizeType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpSizeType", ConfigType.UInt)]
    NamePlateHpSizeType,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorSelf", ConfigType.UInt)]
    NamePlateColorSelf,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeSelf", ConfigType.UInt)]
    NamePlateEdgeSelf,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeSelf", ConfigType.UInt)]
    NamePlateDispTypeSelf,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypeSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypeSelf", ConfigType.UInt)]
    NamePlateNameTypeSelf,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeSelf", ConfigType.UInt)]
    NamePlateHpTypeSelf,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorSelfBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorSelfBuddy", ConfigType.UInt)]
    NamePlateColorSelfBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeSelfBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeSelfBuddy", ConfigType.UInt)]
    NamePlateEdgeSelfBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeSelfBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeSelfBuddy", ConfigType.UInt)]
    NamePlateDispTypeSelfBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeSelfBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeSelfBuddy", ConfigType.UInt)]
    NamePlateHpTypeSelfBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorSelfPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorSelfPet", ConfigType.UInt)]
    NamePlateColorSelfPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeSelfPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeSelfPet", ConfigType.UInt)]
    NamePlateEdgeSelfPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeSelfPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeSelfPet", ConfigType.UInt)]
    NamePlateDispTypeSelfPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeSelfPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeSelfPet", ConfigType.UInt)]
    NamePlateHpTypeSelfPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorParty", ConfigType.UInt)]
    NamePlateColorParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeParty", ConfigType.UInt)]
    NamePlateEdgeParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeParty", ConfigType.UInt)]
    NamePlateDispTypeParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypeParty", ConfigType.UInt)]
    NamePlateNameTypeParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeParty", ConfigType.UInt)]
    NamePlateHpTypeParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypePartyPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypePartyPet", ConfigType.UInt)]
    NamePlateDispTypePartyPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypePartyPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypePartyPet", ConfigType.UInt)]
    NamePlateHpTypePartyPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypePartyBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypePartyBuddy", ConfigType.UInt)]
    NamePlateDispTypePartyBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypePartyBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypePartyBuddy", ConfigType.UInt)]
    NamePlateHpTypePartyBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorAlliance", ConfigType.UInt)]
    NamePlateColorAlliance,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeAlliance", ConfigType.UInt)]
    NamePlateEdgeAlliance,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeAlliance", ConfigType.UInt)]
    NamePlateDispTypeAlliance,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypeAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypeAlliance", ConfigType.UInt)]
    NamePlateNameTypeAlliance,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeAlliance", ConfigType.UInt)]
    NamePlateHpTypeAlliance,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeAlliancePet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeAlliancePet", ConfigType.UInt)]
    NamePlateDispTypeAlliancePet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeAlliancePet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeAlliancePet", ConfigType.UInt)]
    NamePlateHpTypeAlliancePet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorOther", ConfigType.UInt)]
    NamePlateColorOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeOther", ConfigType.UInt)]
    NamePlateEdgeOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeOther", ConfigType.UInt)]
    NamePlateDispTypeOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypeOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypeOther", ConfigType.UInt)]
    NamePlateNameTypeOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeOther", ConfigType.UInt)]
    NamePlateHpTypeOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeOtherPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeOtherPet", ConfigType.UInt)]
    NamePlateDispTypeOtherPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeOtherPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeOtherPet", ConfigType.UInt)]
    NamePlateHpTypeOtherPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeOtherBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeOtherBuddy", ConfigType.UInt)]
    NamePlateDispTypeOtherBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeOtherBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeOtherBuddy", ConfigType.UInt)]
    NamePlateHpTypeOtherBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorUnengagedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorUnengagedEnemy", ConfigType.UInt)]
    NamePlateColorUnengagedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeUnengagedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeUnengagedEnemy", ConfigType.UInt)]
    NamePlateEdgeUnengagedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeUnengagedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeUnengagedEnemy", ConfigType.UInt)]
    NamePlateDispTypeUnengagedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeUnengagedEmemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeUnengagedEmemy", ConfigType.UInt)]
    NamePlateHpTypeUnengagedEmemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorEngagedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorEngagedEnemy", ConfigType.UInt)]
    NamePlateColorEngagedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeEngagedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeEngagedEnemy", ConfigType.UInt)]
    NamePlateEdgeEngagedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeEngagedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeEngagedEnemy", ConfigType.UInt)]
    NamePlateDispTypeEngagedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeEngagedEmemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeEngagedEmemy", ConfigType.UInt)]
    NamePlateHpTypeEngagedEmemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorClaimedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorClaimedEnemy", ConfigType.UInt)]
    NamePlateColorClaimedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeClaimedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeClaimedEnemy", ConfigType.UInt)]
    NamePlateEdgeClaimedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeClaimedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeClaimedEnemy", ConfigType.UInt)]
    NamePlateDispTypeClaimedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeClaimedEmemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeClaimedEmemy", ConfigType.UInt)]
    NamePlateHpTypeClaimedEmemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorUnclaimedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorUnclaimedEnemy", ConfigType.UInt)]
    NamePlateColorUnclaimedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeUnclaimedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeUnclaimedEnemy", ConfigType.UInt)]
    NamePlateEdgeUnclaimedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeUnclaimedEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeUnclaimedEnemy", ConfigType.UInt)]
    NamePlateDispTypeUnclaimedEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeUnclaimedEmemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeUnclaimedEmemy", ConfigType.UInt)]
    NamePlateHpTypeUnclaimedEmemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorNpc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorNpc", ConfigType.UInt)]
    NamePlateColorNpc,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeNpc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeNpc", ConfigType.UInt)]
    NamePlateEdgeNpc,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeNpc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeNpc", ConfigType.UInt)]
    NamePlateDispTypeNpc,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeNpc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeNpc", ConfigType.UInt)]
    NamePlateHpTypeNpc,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorObject.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorObject", ConfigType.UInt)]
    NamePlateColorObject,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeObject.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeObject", ConfigType.UInt)]
    NamePlateEdgeObject,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeObject.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeObject", ConfigType.UInt)]
    NamePlateDispTypeObject,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeObject.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeObject", ConfigType.UInt)]
    NamePlateHpTypeObject,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorMinion.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorMinion", ConfigType.UInt)]
    NamePlateColorMinion,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeMinion.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeMinion", ConfigType.UInt)]
    NamePlateEdgeMinion,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeMinion.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeMinion", ConfigType.UInt)]
    NamePlateDispTypeMinion,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorOtherBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorOtherBuddy", ConfigType.UInt)]
    NamePlateColorOtherBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeOtherBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeOtherBuddy", ConfigType.UInt)]
    NamePlateEdgeOtherBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorOtherPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorOtherPet", ConfigType.UInt)]
    NamePlateColorOtherPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeOtherPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeOtherPet", ConfigType.UInt)]
    NamePlateEdgeOtherPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTitleTypeSelf.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTitleTypeSelf", ConfigType.UInt)]
    NamePlateNameTitleTypeSelf,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTitleTypeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTitleTypeParty", ConfigType.UInt)]
    NamePlateNameTitleTypeParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTitleTypeAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTitleTypeAlliance", ConfigType.UInt)]
    NamePlateNameTitleTypeAlliance,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTitleTypeOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTitleTypeOther", ConfigType.UInt)]
    NamePlateNameTitleTypeOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTitleTypeFriend.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTitleTypeFriend", ConfigType.UInt)]
    NamePlateNameTitleTypeFriend,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorFriend.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorFriend", ConfigType.UInt)]
    NamePlateColorFriend,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorFriendEdge.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorFriendEdge", ConfigType.UInt)]
    NamePlateColorFriendEdge,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeFriend.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeFriend", ConfigType.UInt)]
    NamePlateDispTypeFriend,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypeFriend.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypeFriend", ConfigType.UInt)]
    NamePlateNameTypeFriend,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeFriend.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeFriend", ConfigType.UInt)]
    NamePlateHpTypeFriend,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeFriendPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeFriendPet", ConfigType.UInt)]
    NamePlateDispTypeFriendPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeFriendPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeFriendPet", ConfigType.UInt)]
    NamePlateHpTypeFriendPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeFriendBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeFriendBuddy", ConfigType.UInt)]
    NamePlateDispTypeFriendBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeFriendBuddy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeFriendBuddy", ConfigType.UInt)]
    NamePlateHpTypeFriendBuddy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorLim.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorLim", ConfigType.UInt)]
    NamePlateColorLim,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorLimEdge.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorLimEdge", ConfigType.UInt)]
    NamePlateColorLimEdge,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorGri.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorGri", ConfigType.UInt)]
    NamePlateColorGri,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorGriEdge.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorGriEdge", ConfigType.UInt)]
    NamePlateColorGriEdge,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorUld.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorUld", ConfigType.UInt)]
    NamePlateColorUld,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorUldEdge.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorUldEdge", ConfigType.UInt)]
    NamePlateColorUldEdge,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorHousingFurniture.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorHousingFurniture", ConfigType.UInt)]
    NamePlateColorHousingFurniture,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorHousingFurnitureEdge.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorHousingFurnitureEdge", ConfigType.UInt)]
    NamePlateColorHousingFurnitureEdge,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeHousingFurniture.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeHousingFurniture", ConfigType.UInt)]
    NamePlateDispTypeHousingFurniture,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorHousingField.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorHousingField", ConfigType.UInt)]
    NamePlateColorHousingField,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorHousingFieldEdge.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorHousingFieldEdge", ConfigType.UInt)]
    NamePlateColorHousingFieldEdge,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeHousingField.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeHousingField", ConfigType.UInt)]
    NamePlateDispTypeHousingField,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypePvPEnemy.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypePvPEnemy", ConfigType.UInt)]
    NamePlateNameTypePvPEnemy,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeFeast.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeFeast", ConfigType.UInt)]
    NamePlateDispTypeFeast,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTypeFeast.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTypeFeast", ConfigType.UInt)]
    NamePlateNameTypeFeast,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeFeast.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeFeast", ConfigType.UInt)]
    NamePlateHpTypeFeast,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispTypeFeastPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispTypeFeastPet", ConfigType.UInt)]
    NamePlateDispTypeFeastPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateHpTypeFeastPet.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateHpTypeFeastPet", ConfigType.UInt)]
    NamePlateHpTypeFeastPet,

    /// <summary>
    /// UiConfig option with the internal name NamePlateNameTitleTypeFeast.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateNameTitleTypeFeast", ConfigType.UInt)]
    NamePlateNameTitleTypeFeast,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispSize", ConfigType.UInt)]
    NamePlateDispSize,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispJobIcon.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispJobIcon", ConfigType.UInt)]
    NamePlateDispJobIcon,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispJobIconType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispJobIconType", ConfigType.UInt)]
    NamePlateDispJobIconType,

    /// <summary>
    /// UiConfig option with the internal name NamePlateSetRoleColor.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateSetRoleColor", ConfigType.UInt)]
    NamePlateSetRoleColor,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorTank.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorTank", ConfigType.UInt)]
    NamePlateColorTank,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeTank.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeTank", ConfigType.UInt)]
    NamePlateEdgeTank,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorHealer.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorHealer", ConfigType.UInt)]
    NamePlateColorHealer,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeHealer.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeHealer", ConfigType.UInt)]
    NamePlateEdgeHealer,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorDps.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorDps", ConfigType.UInt)]
    NamePlateColorDps,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeDps.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeDps", ConfigType.UInt)]
    NamePlateEdgeDps,

    /// <summary>
    /// UiConfig option with the internal name NamePlateColorOtherClass.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateColorOtherClass", ConfigType.UInt)]
    NamePlateColorOtherClass,

    /// <summary>
    /// UiConfig option with the internal name NamePlateEdgeOtherClass.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateEdgeOtherClass", ConfigType.UInt)]
    NamePlateEdgeOtherClass,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispWorldTravel.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispWorldTravel", ConfigType.UInt)]
    NamePlateDispWorldTravel,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispJobIconInPublicParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispJobIconInPublicParty", ConfigType.UInt)]
    NamePlateDispJobIconInPublicParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispJobIconInPublicOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispJobIconInPublicOther", ConfigType.UInt)]
    NamePlateDispJobIconInPublicOther,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispJobIconInInstanceParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispJobIconInInstanceParty", ConfigType.UInt)]
    NamePlateDispJobIconInInstanceParty,

    /// <summary>
    /// UiConfig option with the internal name NamePlateDispJobIconInInstanceOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NamePlateDispJobIconInInstanceOther", ConfigType.UInt)]
    NamePlateDispJobIconInInstanceOther,

    /// <summary>
    /// UiConfig option with the internal name ActiveInfo.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ActiveInfo", ConfigType.UInt)]
    ActiveInfo,

    /// <summary>
    /// UiConfig option with the internal name PartyList.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyList", ConfigType.UInt)]
    PartyList,

    /// <summary>
    /// UiConfig option with the internal name PartyListStatus.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyListStatus", ConfigType.UInt)]
    PartyListStatus,

    /// <summary>
    /// UiConfig option with the internal name PartyListStatusTimer.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyListStatusTimer", ConfigType.UInt)]
    PartyListStatusTimer,

    /// <summary>
    /// UiConfig option with the internal name EnemyList.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EnemyList", ConfigType.UInt)]
    EnemyList,

    /// <summary>
    /// UiConfig option with the internal name TargetInfo.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TargetInfo", ConfigType.UInt)]
    TargetInfo,

    /// <summary>
    /// UiConfig option with the internal name Gil.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("Gil", ConfigType.UInt)]
    Gil,

    /// <summary>
    /// UiConfig option with the internal name DTR.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("DTR", ConfigType.UInt)]
    DTR,

    /// <summary>
    /// UiConfig option with the internal name PlayerInfo.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PlayerInfo", ConfigType.UInt)]
    PlayerInfo,

    /// <summary>
    /// UiConfig option with the internal name NaviMap.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("NaviMap", ConfigType.UInt)]
    NaviMap,

    /// <summary>
    /// UiConfig option with the internal name Help.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("Help", ConfigType.UInt)]
    Help,

    /// <summary>
    /// UiConfig option with the internal name CrossMainHelp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CrossMainHelp", ConfigType.UInt)]
    CrossMainHelp,

    /// <summary>
    /// UiConfig option with the internal name HousingLocatePreview.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HousingLocatePreview", ConfigType.UInt)]
    HousingLocatePreview,

    /// <summary>
    /// UiConfig option with the internal name Log.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("Log", ConfigType.UInt)]
    Log,

    /// <summary>
    /// UiConfig option with the internal name LogTell.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTell", ConfigType.UInt)]
    LogTell,

    /// <summary>
    /// UiConfig option with the internal name LogFontSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFontSize", ConfigType.UInt)]
    LogFontSize,

    /// <summary>
    /// UiConfig option with the internal name LogTabName2.
    /// This option is a String.
    /// </summary>
    [GameConfigOption("LogTabName2", ConfigType.String)]
    LogTabName2,

    /// <summary>
    /// UiConfig option with the internal name LogTabName3.
    /// This option is a String.
    /// </summary>
    [GameConfigOption("LogTabName3", ConfigType.String)]
    LogTabName3,

    /// <summary>
    /// UiConfig option with the internal name LogTabFilter0.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTabFilter0", ConfigType.UInt)]
    LogTabFilter0,

    /// <summary>
    /// UiConfig option with the internal name LogTabFilter1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTabFilter1", ConfigType.UInt)]
    LogTabFilter1,

    /// <summary>
    /// UiConfig option with the internal name LogTabFilter2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTabFilter2", ConfigType.UInt)]
    LogTabFilter2,

    /// <summary>
    /// UiConfig option with the internal name LogTabFilter3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTabFilter3", ConfigType.UInt)]
    LogTabFilter3,

    /// <summary>
    /// UiConfig option with the internal name LogChatFilter.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogChatFilter", ConfigType.UInt)]
    LogChatFilter,

    /// <summary>
    /// UiConfig option with the internal name LogEnableErrMsgLv1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogEnableErrMsgLv1", ConfigType.UInt)]
    LogEnableErrMsgLv1,

    /// <summary>
    /// UiConfig option with the internal name LogNameType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogNameType", ConfigType.UInt)]
    LogNameType,

    /// <summary>
    /// UiConfig option with the internal name LogTimeDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTimeDisp", ConfigType.UInt)]
    LogTimeDisp,

    /// <summary>
    /// UiConfig option with the internal name LogTimeSettingType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTimeSettingType", ConfigType.UInt)]
    LogTimeSettingType,

    /// <summary>
    /// UiConfig option with the internal name LogTimeDispType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTimeDispType", ConfigType.UInt)]
    LogTimeDispType,

    /// <summary>
    /// UiConfig option with the internal name IsLogTell.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogTell", ConfigType.UInt)]
    IsLogTell,

    /// <summary>
    /// UiConfig option with the internal name IsLogParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogParty", ConfigType.UInt)]
    IsLogParty,

    /// <summary>
    /// UiConfig option with the internal name LogParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogParty", ConfigType.UInt)]
    LogParty,

    /// <summary>
    /// UiConfig option with the internal name IsLogAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogAlliance", ConfigType.UInt)]
    IsLogAlliance,

    /// <summary>
    /// UiConfig option with the internal name LogAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogAlliance", ConfigType.UInt)]
    LogAlliance,

    /// <summary>
    /// UiConfig option with the internal name IsLogFc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogFc", ConfigType.UInt)]
    IsLogFc,

    /// <summary>
    /// UiConfig option with the internal name LogFc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFc", ConfigType.UInt)]
    LogFc,

    /// <summary>
    /// UiConfig option with the internal name IsLogPvpTeam.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogPvpTeam", ConfigType.UInt)]
    IsLogPvpTeam,

    /// <summary>
    /// UiConfig option with the internal name LogPvpTeam.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogPvpTeam", ConfigType.UInt)]
    LogPvpTeam,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs1", ConfigType.UInt)]
    IsLogLs1,

    /// <summary>
    /// UiConfig option with the internal name LogLs1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs1", ConfigType.UInt)]
    LogLs1,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs2", ConfigType.UInt)]
    IsLogLs2,

    /// <summary>
    /// UiConfig option with the internal name LogLs2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs2", ConfigType.UInt)]
    LogLs2,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs3", ConfigType.UInt)]
    IsLogLs3,

    /// <summary>
    /// UiConfig option with the internal name LogLs3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs3", ConfigType.UInt)]
    LogLs3,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs4", ConfigType.UInt)]
    IsLogLs4,

    /// <summary>
    /// UiConfig option with the internal name LogLs4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs4", ConfigType.UInt)]
    LogLs4,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs5", ConfigType.UInt)]
    IsLogLs5,

    /// <summary>
    /// UiConfig option with the internal name LogLs5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs5", ConfigType.UInt)]
    LogLs5,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs6", ConfigType.UInt)]
    IsLogLs6,

    /// <summary>
    /// UiConfig option with the internal name LogLs6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs6", ConfigType.UInt)]
    LogLs6,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs7", ConfigType.UInt)]
    IsLogLs7,

    /// <summary>
    /// UiConfig option with the internal name LogLs7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs7", ConfigType.UInt)]
    LogLs7,

    /// <summary>
    /// UiConfig option with the internal name IsLogLs8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogLs8", ConfigType.UInt)]
    IsLogLs8,

    /// <summary>
    /// UiConfig option with the internal name LogLs8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogLs8", ConfigType.UInt)]
    LogLs8,

    /// <summary>
    /// UiConfig option with the internal name IsLogBeginner.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogBeginner", ConfigType.UInt)]
    IsLogBeginner,

    /// <summary>
    /// UiConfig option with the internal name LogBeginner.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogBeginner", ConfigType.UInt)]
    LogBeginner,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls", ConfigType.UInt)]
    IsLogCwls,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls2", ConfigType.UInt)]
    IsLogCwls2,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls3", ConfigType.UInt)]
    IsLogCwls3,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls4", ConfigType.UInt)]
    IsLogCwls4,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls5", ConfigType.UInt)]
    IsLogCwls5,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls6", ConfigType.UInt)]
    IsLogCwls6,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls7", ConfigType.UInt)]
    IsLogCwls7,

    /// <summary>
    /// UiConfig option with the internal name IsLogCwls8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsLogCwls8", ConfigType.UInt)]
    IsLogCwls8,

    /// <summary>
    /// UiConfig option with the internal name LogCwls.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls", ConfigType.UInt)]
    LogCwls,

    /// <summary>
    /// UiConfig option with the internal name LogCwls2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls2", ConfigType.UInt)]
    LogCwls2,

    /// <summary>
    /// UiConfig option with the internal name LogCwls3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls3", ConfigType.UInt)]
    LogCwls3,

    /// <summary>
    /// UiConfig option with the internal name LogCwls4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls4", ConfigType.UInt)]
    LogCwls4,

    /// <summary>
    /// UiConfig option with the internal name LogCwls5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls5", ConfigType.UInt)]
    LogCwls5,

    /// <summary>
    /// UiConfig option with the internal name LogCwls6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls6", ConfigType.UInt)]
    LogCwls6,

    /// <summary>
    /// UiConfig option with the internal name LogCwls7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls7", ConfigType.UInt)]
    LogCwls7,

    /// <summary>
    /// UiConfig option with the internal name LogCwls8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCwls8", ConfigType.UInt)]
    LogCwls8,

    /// <summary>
    /// UiConfig option with the internal name LogRecastActionErrDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogRecastActionErrDisp", ConfigType.UInt)]
    LogRecastActionErrDisp,

    /// <summary>
    /// UiConfig option with the internal name LogPermeationRate.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogPermeationRate", ConfigType.UInt)]
    LogPermeationRate,

    /// <summary>
    /// UiConfig option with the internal name LogFontSizeForm.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFontSizeForm", ConfigType.UInt)]
    LogFontSizeForm,

    /// <summary>
    /// UiConfig option with the internal name LogItemLinkEnableType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogItemLinkEnableType", ConfigType.UInt)]
    LogItemLinkEnableType,

    /// <summary>
    /// UiConfig option with the internal name LogFontSizeLog2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFontSizeLog2", ConfigType.UInt)]
    LogFontSizeLog2,

    /// <summary>
    /// UiConfig option with the internal name LogTimeDispLog2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTimeDispLog2", ConfigType.UInt)]
    LogTimeDispLog2,

    /// <summary>
    /// UiConfig option with the internal name LogPermeationRateLog2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogPermeationRateLog2", ConfigType.UInt)]
    LogPermeationRateLog2,

    /// <summary>
    /// UiConfig option with the internal name LogFontSizeLog3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFontSizeLog3", ConfigType.UInt)]
    LogFontSizeLog3,

    /// <summary>
    /// UiConfig option with the internal name LogTimeDispLog3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTimeDispLog3", ConfigType.UInt)]
    LogTimeDispLog3,

    /// <summary>
    /// UiConfig option with the internal name LogPermeationRateLog3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogPermeationRateLog3", ConfigType.UInt)]
    LogPermeationRateLog3,

    /// <summary>
    /// UiConfig option with the internal name LogFontSizeLog4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFontSizeLog4", ConfigType.UInt)]
    LogFontSizeLog4,

    /// <summary>
    /// UiConfig option with the internal name LogTimeDispLog4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogTimeDispLog4", ConfigType.UInt)]
    LogTimeDispLog4,

    /// <summary>
    /// UiConfig option with the internal name LogPermeationRateLog4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogPermeationRateLog4", ConfigType.UInt)]
    LogPermeationRateLog4,

    /// <summary>
    /// UiConfig option with the internal name LogFlyingHeightMaxErrDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogFlyingHeightMaxErrDisp", ConfigType.UInt)]
    LogFlyingHeightMaxErrDisp,

    /// <summary>
    /// UiConfig option with the internal name LogCrossWorldName.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogCrossWorldName", ConfigType.UInt)]
    LogCrossWorldName,

    /// <summary>
    /// UiConfig option with the internal name LogDragResize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogDragResize", ConfigType.UInt)]
    LogDragResize,

    /// <summary>
    /// UiConfig option with the internal name LogNameIconType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogNameIconType", ConfigType.UInt)]
    LogNameIconType,

    /// <summary>
    /// UiConfig option with the internal name LogDispClassJobName.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogDispClassJobName", ConfigType.UInt)]
    LogDispClassJobName,

    /// <summary>
    /// UiConfig option with the internal name LogSetRoleColor.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogSetRoleColor", ConfigType.UInt)]
    LogSetRoleColor,

    /// <summary>
    /// UiConfig option with the internal name LogColorRoleTank.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogColorRoleTank", ConfigType.UInt)]
    LogColorRoleTank,

    /// <summary>
    /// UiConfig option with the internal name LogColorRoleHealer.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogColorRoleHealer", ConfigType.UInt)]
    LogColorRoleHealer,

    /// <summary>
    /// UiConfig option with the internal name LogColorRoleDPS.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogColorRoleDPS", ConfigType.UInt)]
    LogColorRoleDPS,

    /// <summary>
    /// UiConfig option with the internal name LogColorOtherClass.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LogColorOtherClass", ConfigType.UInt)]
    LogColorOtherClass,

    /// <summary>
    /// UiConfig option with the internal name ChatType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ChatType", ConfigType.UInt)]
    ChatType,

    /// <summary>
    /// UiConfig option with the internal name ShopSell.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ShopSell", ConfigType.UInt)]
    ShopSell,

    /// <summary>
    /// UiConfig option with the internal name ColorSay.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorSay", ConfigType.UInt)]
    ColorSay,

    /// <summary>
    /// UiConfig option with the internal name ColorShout.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorShout", ConfigType.UInt)]
    ColorShout,

    /// <summary>
    /// UiConfig option with the internal name ColorTell.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorTell", ConfigType.UInt)]
    ColorTell,

    /// <summary>
    /// UiConfig option with the internal name ColorParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorParty", ConfigType.UInt)]
    ColorParty,

    /// <summary>
    /// UiConfig option with the internal name ColorAlliance.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorAlliance", ConfigType.UInt)]
    ColorAlliance,

    /// <summary>
    /// UiConfig option with the internal name ColorLS1.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS1", ConfigType.UInt)]
    ColorLS1,

    /// <summary>
    /// UiConfig option with the internal name ColorLS2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS2", ConfigType.UInt)]
    ColorLS2,

    /// <summary>
    /// UiConfig option with the internal name ColorLS3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS3", ConfigType.UInt)]
    ColorLS3,

    /// <summary>
    /// UiConfig option with the internal name ColorLS4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS4", ConfigType.UInt)]
    ColorLS4,

    /// <summary>
    /// UiConfig option with the internal name ColorLS5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS5", ConfigType.UInt)]
    ColorLS5,

    /// <summary>
    /// UiConfig option with the internal name ColorLS6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS6", ConfigType.UInt)]
    ColorLS6,

    /// <summary>
    /// UiConfig option with the internal name ColorLS7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS7", ConfigType.UInt)]
    ColorLS7,

    /// <summary>
    /// UiConfig option with the internal name ColorLS8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLS8", ConfigType.UInt)]
    ColorLS8,

    /// <summary>
    /// UiConfig option with the internal name ColorFCompany.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorFCompany", ConfigType.UInt)]
    ColorFCompany,

    /// <summary>
    /// UiConfig option with the internal name ColorPvPGroup.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorPvPGroup", ConfigType.UInt)]
    ColorPvPGroup,

    /// <summary>
    /// UiConfig option with the internal name ColorPvPGroupAnnounce.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorPvPGroupAnnounce", ConfigType.UInt)]
    ColorPvPGroupAnnounce,

    /// <summary>
    /// UiConfig option with the internal name ColorBeginner.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorBeginner", ConfigType.UInt)]
    ColorBeginner,

    /// <summary>
    /// UiConfig option with the internal name ColorEmoteUser.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorEmoteUser", ConfigType.UInt)]
    ColorEmoteUser,

    /// <summary>
    /// UiConfig option with the internal name ColorEmote.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorEmote", ConfigType.UInt)]
    ColorEmote,

    /// <summary>
    /// UiConfig option with the internal name ColorYell.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorYell", ConfigType.UInt)]
    ColorYell,

    /// <summary>
    /// UiConfig option with the internal name ColorBeginnerAnnounce.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorBeginnerAnnounce", ConfigType.UInt)]
    ColorBeginnerAnnounce,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS", ConfigType.UInt)]
    ColorCWLS,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS2.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS2", ConfigType.UInt)]
    ColorCWLS2,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS3.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS3", ConfigType.UInt)]
    ColorCWLS3,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS4.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS4", ConfigType.UInt)]
    ColorCWLS4,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS5.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS5", ConfigType.UInt)]
    ColorCWLS5,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS6.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS6", ConfigType.UInt)]
    ColorCWLS6,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS7.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS7", ConfigType.UInt)]
    ColorCWLS7,

    /// <summary>
    /// UiConfig option with the internal name ColorCWLS8.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCWLS8", ConfigType.UInt)]
    ColorCWLS8,

    /// <summary>
    /// UiConfig option with the internal name ColorAttackSuccess.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorAttackSuccess", ConfigType.UInt)]
    ColorAttackSuccess,

    /// <summary>
    /// UiConfig option with the internal name ColorAttackFailure.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorAttackFailure", ConfigType.UInt)]
    ColorAttackFailure,

    /// <summary>
    /// UiConfig option with the internal name ColorAction.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorAction", ConfigType.UInt)]
    ColorAction,

    /// <summary>
    /// UiConfig option with the internal name ColorItem.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorItem", ConfigType.UInt)]
    ColorItem,

    /// <summary>
    /// UiConfig option with the internal name ColorCureGive.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCureGive", ConfigType.UInt)]
    ColorCureGive,

    /// <summary>
    /// UiConfig option with the internal name ColorBuffGive.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorBuffGive", ConfigType.UInt)]
    ColorBuffGive,

    /// <summary>
    /// UiConfig option with the internal name ColorDebuffGive.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorDebuffGive", ConfigType.UInt)]
    ColorDebuffGive,

    /// <summary>
    /// UiConfig option with the internal name ColorEcho.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorEcho", ConfigType.UInt)]
    ColorEcho,

    /// <summary>
    /// UiConfig option with the internal name ColorSysMsg.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorSysMsg", ConfigType.UInt)]
    ColorSysMsg,

    /// <summary>
    /// UiConfig option with the internal name ColorFCAnnounce.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorFCAnnounce", ConfigType.UInt)]
    ColorFCAnnounce,

    /// <summary>
    /// UiConfig option with the internal name ColorSysBattle.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorSysBattle", ConfigType.UInt)]
    ColorSysBattle,

    /// <summary>
    /// UiConfig option with the internal name ColorSysGathering.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorSysGathering", ConfigType.UInt)]
    ColorSysGathering,

    /// <summary>
    /// UiConfig option with the internal name ColorSysErr.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorSysErr", ConfigType.UInt)]
    ColorSysErr,

    /// <summary>
    /// UiConfig option with the internal name ColorNpcSay.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorNpcSay", ConfigType.UInt)]
    ColorNpcSay,

    /// <summary>
    /// UiConfig option with the internal name ColorItemNotice.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorItemNotice", ConfigType.UInt)]
    ColorItemNotice,

    /// <summary>
    /// UiConfig option with the internal name ColorGrowup.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorGrowup", ConfigType.UInt)]
    ColorGrowup,

    /// <summary>
    /// UiConfig option with the internal name ColorLoot.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorLoot", ConfigType.UInt)]
    ColorLoot,

    /// <summary>
    /// UiConfig option with the internal name ColorCraft.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorCraft", ConfigType.UInt)]
    ColorCraft,

    /// <summary>
    /// UiConfig option with the internal name ColorGathering.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ColorGathering", ConfigType.UInt)]
    ColorGathering,

    /// <summary>
    /// UiConfig option with the internal name ShopConfirm.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ShopConfirm", ConfigType.UInt)]
    ShopConfirm,

    /// <summary>
    /// UiConfig option with the internal name ShopConfirmMateria.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ShopConfirmMateria", ConfigType.UInt)]
    ShopConfirmMateria,

    /// <summary>
    /// UiConfig option with the internal name ShopConfirmExRare.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ShopConfirmExRare", ConfigType.UInt)]
    ShopConfirmExRare,

    /// <summary>
    /// UiConfig option with the internal name ShopConfirmSpiritBondMax.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ShopConfirmSpiritBondMax", ConfigType.UInt)]
    ShopConfirmSpiritBondMax,

    /// <summary>
    /// UiConfig option with the internal name ItemSortItemCategory.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemSortItemCategory", ConfigType.UInt)]
    ItemSortItemCategory,

    /// <summary>
    /// UiConfig option with the internal name ItemSortEquipLevel.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemSortEquipLevel", ConfigType.UInt)]
    ItemSortEquipLevel,

    /// <summary>
    /// UiConfig option with the internal name ItemSortItemLevel.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemSortItemLevel", ConfigType.UInt)]
    ItemSortItemLevel,

    /// <summary>
    /// UiConfig option with the internal name ItemSortItemStack.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemSortItemStack", ConfigType.UInt)]
    ItemSortItemStack,

    /// <summary>
    /// UiConfig option with the internal name ItemSortTidyingType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemSortTidyingType", ConfigType.UInt)]
    ItemSortTidyingType,

    /// <summary>
    /// UiConfig option with the internal name ItemNoArmoryMaskOff.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemNoArmoryMaskOff", ConfigType.UInt)]
    ItemNoArmoryMaskOff,

    /// <summary>
    /// UiConfig option with the internal name ItemInventryStoreEnd.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemInventryStoreEnd", ConfigType.UInt)]
    ItemInventryStoreEnd,

    /// <summary>
    /// UiConfig option with the internal name InfoSettingDispWorldNameType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("InfoSettingDispWorldNameType", ConfigType.UInt)]
    InfoSettingDispWorldNameType,

    /// <summary>
    /// UiConfig option with the internal name TargetNamePlateNameType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TargetNamePlateNameType", ConfigType.UInt)]
    TargetNamePlateNameType,

    /// <summary>
    /// UiConfig option with the internal name FocusTargetNamePlateNameType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FocusTargetNamePlateNameType", ConfigType.UInt)]
    FocusTargetNamePlateNameType,

    /// <summary>
    /// UiConfig option with the internal name ItemDetailTemporarilySwitch.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemDetailTemporarilySwitch", ConfigType.UInt)]
    ItemDetailTemporarilySwitch,

    /// <summary>
    /// UiConfig option with the internal name ItemDetailTemporarilySwitchKey.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemDetailTemporarilySwitchKey", ConfigType.UInt)]
    ItemDetailTemporarilySwitchKey,

    /// <summary>
    /// UiConfig option with the internal name ItemDetailTemporarilyHide.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemDetailTemporarilyHide", ConfigType.UInt)]
    ItemDetailTemporarilyHide,

    /// <summary>
    /// UiConfig option with the internal name ItemDetailTemporarilyHideKey.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemDetailTemporarilyHideKey", ConfigType.UInt)]
    ItemDetailTemporarilyHideKey,

    /// <summary>
    /// UiConfig option with the internal name ToolTipDispSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ToolTipDispSize", ConfigType.UInt)]
    ToolTipDispSize,

    /// <summary>
    /// UiConfig option with the internal name RecommendLoginDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("RecommendLoginDisp", ConfigType.UInt)]
    RecommendLoginDisp,

    /// <summary>
    /// UiConfig option with the internal name RecommendAreaChangeDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("RecommendAreaChangeDisp", ConfigType.UInt)]
    RecommendAreaChangeDisp,

    /// <summary>
    /// UiConfig option with the internal name PlayGuideLoginDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PlayGuideLoginDisp", ConfigType.UInt)]
    PlayGuideLoginDisp,

    /// <summary>
    /// UiConfig option with the internal name PlayGuideAreaChangeDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PlayGuideAreaChangeDisp", ConfigType.UInt)]
    PlayGuideAreaChangeDisp,

    /// <summary>
    /// UiConfig option with the internal name MapPadOperationYReverse.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MapPadOperationYReverse", ConfigType.UInt)]
    MapPadOperationYReverse,

    /// <summary>
    /// UiConfig option with the internal name MapPadOperationXReverse.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MapPadOperationXReverse", ConfigType.UInt)]
    MapPadOperationXReverse,

    /// <summary>
    /// UiConfig option with the internal name MapDispSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MapDispSize", ConfigType.UInt)]
    MapDispSize,

    /// <summary>
    /// UiConfig option with the internal name FlyTextDispSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FlyTextDispSize", ConfigType.UInt)]
    FlyTextDispSize,

    /// <summary>
    /// UiConfig option with the internal name PopUpTextDispSize.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PopUpTextDispSize", ConfigType.UInt)]
    PopUpTextDispSize,

    /// <summary>
    /// UiConfig option with the internal name DetailDispDelayType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("DetailDispDelayType", ConfigType.UInt)]
    DetailDispDelayType,

    /// <summary>
    /// UiConfig option with the internal name PartyListSortTypeTank.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyListSortTypeTank", ConfigType.UInt)]
    PartyListSortTypeTank,

    /// <summary>
    /// UiConfig option with the internal name PartyListSortTypeHealer.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyListSortTypeHealer", ConfigType.UInt)]
    PartyListSortTypeHealer,

    /// <summary>
    /// UiConfig option with the internal name PartyListSortTypeDps.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyListSortTypeDps", ConfigType.UInt)]
    PartyListSortTypeDps,

    /// <summary>
    /// UiConfig option with the internal name PartyListSortTypeOther.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyListSortTypeOther", ConfigType.UInt)]
    PartyListSortTypeOther,

    /// <summary>
    /// UiConfig option with the internal name RatioHpDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("RatioHpDisp", ConfigType.UInt)]
    RatioHpDisp,

    /// <summary>
    /// UiConfig option with the internal name BuffDispType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BuffDispType", ConfigType.UInt)]
    BuffDispType,

    /// <summary>
    /// UiConfig option with the internal name ContentsFinderListSortType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsFinderListSortType", ConfigType.UInt)]
    ContentsFinderListSortType,

    /// <summary>
    /// UiConfig option with the internal name ContentsFinderSupplyEnable.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsFinderSupplyEnable", ConfigType.UInt)]
    ContentsFinderSupplyEnable,

    /// <summary>
    /// UiConfig option with the internal name EnemyListCastbarEnable.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EnemyListCastbarEnable", ConfigType.UInt)]
    EnemyListCastbarEnable,

    /// <summary>
    /// UiConfig option with the internal name AchievementAppealLoginDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("AchievementAppealLoginDisp", ConfigType.UInt)]
    AchievementAppealLoginDisp,

    /// <summary>
    /// UiConfig option with the internal name ContentsFinderUseLangTypeJA.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsFinderUseLangTypeJA", ConfigType.UInt)]
    ContentsFinderUseLangTypeJA,

    /// <summary>
    /// UiConfig option with the internal name ContentsFinderUseLangTypeEN.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsFinderUseLangTypeEN", ConfigType.UInt)]
    ContentsFinderUseLangTypeEN,

    /// <summary>
    /// UiConfig option with the internal name ContentsFinderUseLangTypeDE.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsFinderUseLangTypeDE", ConfigType.UInt)]
    ContentsFinderUseLangTypeDE,

    /// <summary>
    /// UiConfig option with the internal name ContentsFinderUseLangTypeFR.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsFinderUseLangTypeFR", ConfigType.UInt)]
    ContentsFinderUseLangTypeFR,

    /// <summary>
    /// UiConfig option with the internal name ItemInventryWindowSizeType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemInventryWindowSizeType", ConfigType.UInt)]
    ItemInventryWindowSizeType,

    /// <summary>
    /// UiConfig option with the internal name ItemInventryRetainerWindowSizeType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ItemInventryRetainerWindowSizeType", ConfigType.UInt)]
    ItemInventryRetainerWindowSizeType,

    /// <summary>
    /// UiConfig option with the internal name BattleTalkShowFace.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BattleTalkShowFace", ConfigType.UInt)]
    BattleTalkShowFace,

    /// <summary>
    /// UiConfig option with the internal name BannerContentsDispType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BannerContentsDispType", ConfigType.UInt)]
    BannerContentsDispType,

    /// <summary>
    /// UiConfig option with the internal name BannerContentsNotice.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BannerContentsNotice", ConfigType.UInt)]
    BannerContentsNotice,

    /// <summary>
    /// UiConfig option with the internal name MipDispType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MipDispType", ConfigType.UInt)]
    MipDispType,

    /// <summary>
    /// UiConfig option with the internal name BannerContentsOrderType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("BannerContentsOrderType", ConfigType.UInt)]
    BannerContentsOrderType,

    /// <summary>
    /// UiConfig option with the internal name CCProgressAllyFixLeftSide.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CCProgressAllyFixLeftSide", ConfigType.UInt)]
    CCProgressAllyFixLeftSide,

    /// <summary>
    /// UiConfig option with the internal name CCMapAllyFixLeftSide.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("CCMapAllyFixLeftSide", ConfigType.UInt)]
    CCMapAllyFixLeftSide,

    /// <summary>
    /// UiConfig option with the internal name DispCCCountDown.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("DispCCCountDown", ConfigType.UInt)]
    DispCCCountDown,

    /// <summary>
    /// UiConfig option with the internal name EmoteTextType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EmoteTextType", ConfigType.UInt)]
    EmoteTextType,

    /// <summary>
    /// UiConfig option with the internal name IsEmoteSe.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("IsEmoteSe", ConfigType.UInt)]
    IsEmoteSe,

    /// <summary>
    /// UiConfig option with the internal name EmoteSeType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("EmoteSeType", ConfigType.UInt)]
    EmoteSeType,

    /// <summary>
    /// UiConfig option with the internal name PartyFinderNewArrivalDisp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PartyFinderNewArrivalDisp", ConfigType.UInt)]
    PartyFinderNewArrivalDisp,

    /// <summary>
    /// UiConfig option with the internal name GPoseTargetFilterNPCLookAt.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GPoseTargetFilterNPCLookAt", ConfigType.UInt)]
    GPoseTargetFilterNPCLookAt,

    /// <summary>
    /// UiConfig option with the internal name GPoseMotionFilterAction.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("GPoseMotionFilterAction", ConfigType.UInt)]
    GPoseMotionFilterAction,

    /// <summary>
    /// UiConfig option with the internal name LsListSortPriority.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LsListSortPriority", ConfigType.UInt)]
    LsListSortPriority,

    /// <summary>
    /// UiConfig option with the internal name FriendListSortPriority.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FriendListSortPriority", ConfigType.UInt)]
    FriendListSortPriority,

    /// <summary>
    /// UiConfig option with the internal name FriendListFilterType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FriendListFilterType", ConfigType.UInt)]
    FriendListFilterType,

    /// <summary>
    /// UiConfig option with the internal name FriendListSortType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("FriendListSortType", ConfigType.UInt)]
    FriendListSortType,

    /// <summary>
    /// UiConfig option with the internal name LetterListFilterType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LetterListFilterType", ConfigType.UInt)]
    LetterListFilterType,

    /// <summary>
    /// UiConfig option with the internal name LetterListSortType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("LetterListSortType", ConfigType.UInt)]
    LetterListSortType,

    /// <summary>
    /// UiConfig option with the internal name ContentsReplayEnable.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("ContentsReplayEnable", ConfigType.UInt)]
    ContentsReplayEnable,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationUp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationUp", ConfigType.UInt)]
    MouseWheelOperationUp,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationDown.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationDown", ConfigType.UInt)]
    MouseWheelOperationDown,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationCtrlUp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationCtrlUp", ConfigType.UInt)]
    MouseWheelOperationCtrlUp,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationCtrlDown.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationCtrlDown", ConfigType.UInt)]
    MouseWheelOperationCtrlDown,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationAltUp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationAltUp", ConfigType.UInt)]
    MouseWheelOperationAltUp,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationAltDown.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationAltDown", ConfigType.UInt)]
    MouseWheelOperationAltDown,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationShiftUp.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationShiftUp", ConfigType.UInt)]
    MouseWheelOperationShiftUp,

    /// <summary>
    /// UiConfig option with the internal name MouseWheelOperationShiftDown.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("MouseWheelOperationShiftDown", ConfigType.UInt)]
    MouseWheelOperationShiftDown,

    /// <summary>
    /// UiConfig option with the internal name TelepoTicketUseType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TelepoTicketUseType", ConfigType.UInt)]
    TelepoTicketUseType,

    /// <summary>
    /// UiConfig option with the internal name TelepoTicketGilSetting.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TelepoTicketGilSetting", ConfigType.UInt)]
    TelepoTicketGilSetting,

    /// <summary>
    /// UiConfig option with the internal name TelepoCategoryType.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("TelepoCategoryType", ConfigType.UInt)]
    TelepoCategoryType,

    /// <summary>
    /// UiConfig option with the internal name HidePcAroundQuestProgressNpc.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HidePcAroundQuestProgressNpc", ConfigType.UInt)]
    HidePcAroundQuestProgressNpc,

    /// <summary>
    /// UiConfig option with the internal name HidePcAroundQuestProgressNpcIncludeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HidePcAroundQuestProgressNpcIncludeParty", ConfigType.UInt)]
    HidePcAroundQuestProgressNpcIncludeParty,

    /// <summary>
    /// UiConfig option with the internal name HidePcAroundNpcAccessingQuest.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HidePcAroundNpcAccessingQuest", ConfigType.UInt)]
    HidePcAroundNpcAccessingQuest,

    /// <summary>
    /// UiConfig option with the internal name HidePcAroundNpcAccessingQuestIncludeParty.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("HidePcAroundNpcAccessingQuestIncludeParty", ConfigType.UInt)]
    HidePcAroundNpcAccessingQuestIncludeParty,

    /// <summary>
    /// UiConfig option with the internal name PvPFrontlinesGCFree.
    /// This option is a UInt.
    /// </summary>
    [GameConfigOption("PvPFrontlinesGCFree", ConfigType.UInt)]
    PvPFrontlinesGCFree,
}
