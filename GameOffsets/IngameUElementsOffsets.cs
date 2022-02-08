using System.Runtime.InteropServices;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct IngameUElementsOffsets
    {
        [FieldOffset(0x250)] public long GetQuests;
        [FieldOffset(0x288)] public long GameUI;
        [FieldOffset(0x3C0)] public long Mouse;
        [FieldOffset(0x3C8)] public long SkillBar;
        [FieldOffset(0x3D0)] public long HiddenSkillBar;
        [FieldOffset(0x3E0)] public long PartyElement;
        [FieldOffset(0x420)] public long BanditDialog;
        [FieldOffset(0x470)] public long ChatPanel;
        [FieldOffset(0x4F8)] public long QuestTracker;
        [FieldOffset(0x560)] public long OpenLeftPanel;
        [FieldOffset(0x568)] public long OpenRightPanel;
        [FieldOffset(0x598)] public long InventoryPanel;
        [FieldOffset(0x5A0)] public long StashElement;
        [FieldOffset(0x648)] public long AtlasPanel;
        [FieldOffset(0x650)] public long AtlasSkillPanel;
        [FieldOffset(0x680)] public long WorldMap;
        [FieldOffset(0x6A8)] public long Map;
        [FieldOffset(0x6B0)] public long itemsOnGroundLabelRoot;
        [FieldOffset(0x740)] public long NpcDialog;
        //[FieldOffset(0x750)] public long LeagueNpcDialog;
        [FieldOffset(0x758)] public long QuestRewardWindow;
        [FieldOffset(0x760)] public long PurchaseWindow;
        [FieldOffset(0x768)] public long ExpeditionPurchaseWindow;
        [FieldOffset(0x778)] public long SellWindow;
        [FieldOffset(0x780)] public long ExpeditionSellWindow;
        [FieldOffset(0x780)] public long TradeWindow;
        [FieldOffset(0x798)] public long LabyrinthDivineFontPanel;
        [FieldOffset(0x7B0)] public long MapDeviceWindow;
        [FieldOffset(0x810)] public long IncursionWindow;
        [FieldOffset(0x828)] public long DelveWindow;
        [FieldOffset(0x838)] public long ZanaMissionChoice;
        [FieldOffset(0x858)] public long BetrayalWindow;
        [FieldOffset(0x860)] public long CraftBenchWindow;
        [FieldOffset(0x868)] public long UnveilWindow;
        [FieldOffset(0x880)] public long SynthesisWindow;
        [FieldOffset(0x840)] public long MetamorphWindow; // TODO
        [FieldOffset(0x8B0)] public long HarvestWindow;
        [FieldOffset(0x8C0)] public long HeistContractPanel;
        [FieldOffset(0x8C8)] public long HeistRevealPanel;
        [FieldOffset(0x8D0)] public long HeistAllyEquipmentPanel;
        [FieldOffset(0x8D8)] public long HeistBlueprintPanel;
        [FieldOffset(0x8E0)] public long HeistLockerPanel;
        [FieldOffset(0x8E8)] public long RitualWindow;
        [FieldOffset(0x898)] public long UltimatumProgressPanel; // TODO
        [FieldOffset(0x900)] public long RitualFavourPanel;
        [FieldOffset(0x950)] public long DelveDarkness; // Is actually debuff panel.
        [FieldOffset(0x990)] public long AreaInstanceUi;
        [FieldOffset(0xA98)] public long InvitesPanel; // TODO
        [FieldOffset(0xAE0)] public long GemLvlUpPanel;
        [FieldOffset(0xBB8)] public long ItemOnGroundTooltip; // TODO
        [FieldOffset(0xAA0)] public long MapTabWindowStartPtr; // TODO

        //[FieldOffset(0x258)] public long GetQuests;
        //[FieldOffset(0x280)] public long GameUI;
        //[FieldOffset(0x288)] public long LeftGameUI;
        //[FieldOffset(0x290)] public long RightGameUI;
        //[FieldOffset(0x298)] public long HealthPanel;
        //[FieldOffset(0x2A0)] public long ManaPanel;
        //[FieldOffset(0x2C0)] public long FlaskPanel;
        //[FieldOffset(0x2C8)] public long ExperienceBarPanel;
        //[FieldOffset(0x298)] public long MenuPanel;
        //[FieldOffset(0x2A0)] public long MenuButton;
        //[FieldOffset(0x2B8)] public long ClockPanel;
        //[FieldOffset(0x2C0)] public long MenuOptionOptions;
        //[FieldOffset(0x2C8)] public long MenuOptionSocial;
        //[FieldOffset(0x2D0)] public long MenuOptionCharacter;
        //[FieldOffset(0x2D8)] public long MenuOptionPassiveTree;
        //[FieldOffset(0x2E0)] public long MenuOptionInventory;
        //[FieldOffset(0x2E8)] public long MenuOptionCosmetics;
        //[FieldOffset(0x2F0)] public long MenuOptionMTX;
        //[FieldOffset(0x2F8)] public long MenuOptionChallenges;
        //[FieldOffset(0x300)] public long MenuOptionEvents;
        //[FieldOffset(0x308)] public long MenuOptionWorld;
        //[FieldOffset(0x310)] public long MenuOptionSocial;
        //[FieldOffset(0x318)] public long MenuOptionOverlay;
        //[FieldOffset(0x338)] public long MTXShopButton;
        //[FieldOffset(0x340)] public long HelpButton;
        //[FieldOffset(0x358)] public long SkillPointAvailableButton;
        //[FieldOffset(0x360)] public long QuestNotificationButton;
        //[FieldOffset(0x368)] public long SkipTutorialButton;
        //[FieldOffset(0x380)] public long ToggleChatButton;
        //[FieldOffset(0x390)] public long Mouse;
        //[FieldOffset(0x398)] public long SkillBar;
        //[FieldOffset(0x3A0)] public long HiddenSkillBar;
        //[FieldOffset(0x3B0)] public long Child19;
        //[FieldOffset(0x3B8)] public long Child18;
        //[FieldOffset(0x3C0)] public long PvpLeaveWithdrawPanel;
        //[FieldOffset(0x3C8)] public long PvpTimerPanel;
        //[FieldOffset(0x3D0)] public long PvpFightNotifyPanel;
        //[FieldOffset(0x3D8)] public long PvpNextRoundPanel;
        //[FieldOffset(0x3E0)] public long PvpStopSpectatingPanel;
        //[FieldOffset(0x3E8)] public long Child51;
        //[FieldOffset(0x3F0)] public long PvpTimers;
        //[FieldOffset(0x400)] public long PvpSpectatingPanel;
        //[FieldOffset(0x408)] public long Child109;
        //[FieldOffset(0x410)] public long EditingNotifyPanel;
        //[FieldOffset(0x420)] public long ChatPanel;
        //[FieldOffset(0x428)] public long HideoutStashPanel;
        //[FieldOffset(0x430)] public long Child116;
        //[FieldOffset(0x438)] public long Child117;
        //[FieldOffset(0x440)] public long BestiaryMissionCompletePanel;
        //[FieldOffset(0x448)] public long BestiaryNewBeastNotifyPanel;
        //[FieldOffset(0x450)] public long BestiaryNewRecipeNotifyPanel;
        //[FieldOffset(0x488)] public long SulphiteProgressBar;
        //[FieldOffset(0x490)] public long Child118;
        //[FieldOffset(0x498)] public long Child119;
        //[FieldOffset(0x4A0)] public long QuestTracker;
        //[FieldOffset(0x4A8)] public long BenchCraftNewRecipeNotifyPanel;
        //[FieldOffset(0x4C8)] public long HideoutUnlockNotifyPanel;
        //[FieldOffset(0x508)] public long OpenLeftPanel;
        //[FieldOffset(0x510)] public long OpenRightPanel;
        //[FieldOffset(0x518)] public long OpenLeftPanel2; // Holds same address as above.
        //[FieldOffset(0x520)] public long OpenRightPanel2; // Holds same address as above.
        //[FieldOffset(0x530)] public long MtxStashPanel;
        //[FieldOffset(0x538)] public long MtxShopPanel;
        //[FieldOffset(0x540)] public long InventoryPanel;
        //[FieldOffset(0x548)] public long StashElement;
        //[FieldOffset(0x558)] public long GuildStashPanel;
        //[FieldOffset(0x560)] public long HideoutStashPanel; // Hideout stash panels from before rework.
        //[FieldOffset(0x568)] public long SocialPanel;
        //[FieldOffset(0x5F8)] public long AtlasPanel;
        //[FieldOffset(0x600)] public long CharacterPanel;
        //[FieldOffset(0x608)] public long OptionsPanel;
        //[FieldOffset(0x610)] public long ChallengesPanel;
        //[FieldOffset(0x618)] public long PantheonPanel;
        //[FieldOffset(0x620)] public long EventsPanel;
        //[FieldOffset(0x628)] public long WorldMap;
        //[FieldOffset(0x630)] public long MtxPanel;
        //[FieldOffset(0x638)] public long DecorationsPanel;
        //[FieldOffset(0x640)] public long HelpPanel;
        //[FieldOffset(0x648)] public long Map;
        //[FieldOffset(0x650)] public long itemsOnGroundLabelRoot;
        //[FieldOffset(0x658)] public long BanditDialog;
        //[FieldOffset(0x660)] public long Child8;
        //[FieldOffset(0x668)] public long Child9;
        //[FieldOffset(0x670)] public long Child10;
        //[FieldOffset(0x680)] public long Child2;
        //[FieldOffset(0x688)] public long Child128;
        //[FieldOffset(0x6D0)] public long BuffPanel;
        //[FieldOffset(0x6D8)] public long NpcDialog;
        //[FieldOffset(0x6E8)] public long LeagueInterfaceButton;
        //[FieldOffset(0x6F0)] public long QuestRewardWindow;
        //[FieldOffset(0x6F8)] public long PurchaseWindow;
        //[FieldOffset(0x700)] public long ExpeditionPurchaseWindow;
        //[FieldOffset(0x708)] public long SellWindow;
        //[FieldOffset(0x710)] public long ExpeditionSellWindow;
        //[FieldOffset(0x718)] public long TradeWindow;
        //[FieldOffset(0x720)] public long MapReceptacle;
        //[FieldOffset(0x728)] public long PerandusCadiroOfferPanel;
        //[FieldOffset(0x730)] public long LabyrinthDivineFontPanel;
        //[FieldOffset(0x738)] public long TalismanStoneCirclePanel;
        //[FieldOffset(0x740)] public long TrialPlaquePanel;
        //[FieldOffset(0x748)] public long AscendancySelectPanel;
        //[FieldOffset(0x750)] public long MapDeviceWindow;
        //[FieldOffset(0x758)] public long DarkshrinePanel;
        //[FieldOffset(0x760)] public long BestiaryCraftPanel;
        //[FieldOffset(0x768)] public long LabyrinthSelectPanel;
        //[FieldOffset(0x770)] public long LabyrinthMapPanel;
        //[FieldOffset(0x778)] public long GuildTagEditor;
        //[FieldOffset(0x780)] public long BroadcastMessagePanel;
        //[FieldOffset(0x788)] public long FriendNoteEditorPanel;
        //[FieldOffset(0x790)] public long BetaLadderScreen;
        //[FieldOffset(0x798)] public long PVPScoreboardPanel;
        //[FieldOffset(0x7A0)] public long DivinationCardTradeScreen;
        //[FieldOffset(0x7A8)] public long IncursionWindow;
        //[FieldOffset(0x7B0)] public long IncursionCorruptionAltarPanel;
        //[FieldOffset(0x7B8)] public long IncursionAltarOfSacrificePanel;
        //[FieldOffset(0x7C0)] public long IncursionLapidaryLensPanel;
        //[FieldOffset(0x7C8)] public long NikoSubterraneanChartPanel;
        //[FieldOffset(0x7D0)] public long DelveWindow; // Not used.
        //[FieldOffset(0x7D8)] public long ZanaMissionChoice;
        //[FieldOffset(0x7E0)] public long SupportGemsTutorialPanel;
        //[FieldOffset(0x7E8)] public long JunSyndicateInvestigationPanel;
        //[FieldOffset(0x7F0)] public long BetrayalWindow; // Not used.
        //[FieldOffset(0x7F8)] public long HelenaHideoutSelectPanel;
        //[FieldOffset(0x800)] public long CraftBenchWindow;
        //[FieldOffset(0x808)] public long UnveilWindow;
        //[FieldOffset(0x810)] public long BetrayalTrappedStashPanel;
        //[FieldOffset(0x818)] public long BetrayalTinysTrialPanel;
        //[FieldOffset(0x820)] public long BetrayalSyndicateCraftingBenchPanel;
        //[FieldOffset(0x828)] public long SynthesisSynthesiserPanel;
        //[FieldOffset(0x830)] public long SynthesisWindow;
        //[FieldOffset(0x838)] public long CassiaAnointPanel;
        //[FieldOffset(0x840)] public long MetamorphWindow;  // This is the panel you encounter in maps.
        //[FieldOffset(0x848)] public long TanesLabMetamorphWindow; // This is the panel you encounter in Tane's Lab.
        //[FieldOffset(0x850)] public long HarvestWindow;
        //[FieldOffset(0x858)] public long HorticraftingStationPanel;
        //[FieldOffset(0x888)] public long RitualWindow;
        //[FieldOffset(0x890)] public long RitualFavourPanel;
        //[FieldOffset(0x898)] public long UltimatumProgressPanel;
        //[FieldOffset(0x8A0)] public long ExpeditionMapPanel;
        //[FieldOffset(0x8A8)] public long ExpeditionLogbookPanel;
        //[FieldOffset(0x8B0)] public long ExpeditionLockerPanel;
        //[FieldOffset(0x8B8)] public long ItemBoxPanel;
        //[FieldOffset(0x8C0)] public long PvpNewPanel;
        //[FieldOffset(0x8C8)] public long BuffsMinionsPanel; // Golems
        //[FieldOffset(0x8D0)] public long BuffsDeployedObjectsPanel; // Brands
        //[FieldOffset(0x8D8)] public long BuffsOnlyPanel;
        //[FieldOffset(0x8E0)] public long DelveDarkness; // Debuffs
        //[FieldOffset(0x8E8)] public long BuffsHeistAlliesPanel; // Heist Allies
        //[FieldOffset(0x8F0)] public long BuffsRelatedPanel; // Still figuring these out.
        //[FieldOffset(0x8F8)] public long BuffsRelatedPanel; // Still figuring these out.
        //[FieldOffset(0x900)] public long MapSettingsPanel;
        //[FieldOffset(0x908)] public long Child106;
        //[FieldOffset(0x910)] public long Child139;
        //[FieldOffset(0x920)] public long AreaInstanceUi;
        //[FieldOffset(0x928)] public long Child130;
        //[FieldOffset(0x930)] public long Child131;
        //[FieldOffset(0x938)] public long MysteryBoxPanel;
        //[FieldOffset(0x940)] public long MtxSalvagePanel;
        //[FieldOffset(0x948)] public long MTXReclaimPanel;
        //[FieldOffset(0x950)] public long MtxCombinePanel;
        //[FieldOffset(0x958)] public long ReportPlayerPanel;
        //[FieldOffset(0x960)] public long Child136;
        //[FieldOffset(0x970)] public long DeadNotifyPanel;
        //[FieldOffset(0x978)] public long ResurrectInTownButton;
        //[FieldOffset(0x980)] public long ResurrectAtCheckpointButton;
        //[FieldOffset(0x988)] public long ReviveAtCheckpointButton;
        //[FieldOffset(0x990)] public long UnknownResurrectionButton;
        //[FieldOffset(0x998)] public long SkipAheadButton;
        //[FieldOffset(0x9A0)] public long BetrayalHelpButton;
        //[FieldOffset(0x9D0)] public long ParentLeagueInteractPanel;
        //[FieldOffset(0x9D8)] public long MetamorphInteractPanel;
        //[FieldOffset(0x9E0)] public long RitualInteractButton;
        //[FieldOffset(0x9F0)] public long ExpeditionInteractPanel;
        //[FieldOffset(0x9F8)] public long Child1;
        //[FieldOffset(0xA00)] public long HideoutEditPanel;
        //[FieldOffset(0xA08)] public long HideoutMusicPanel;
        //[FieldOffset(0xA18)] public long ZoneTravelNotifyPanel;
        //[FieldOffset(0xA20)] public long InvitesPanel;
        //[FieldOffset(0xA28)] public long Child5;
        //[FieldOffset(0xA70)] public long GemLvlUpPanel;
        //[FieldOffset(0xA78)] public long GameUI2;
        //[FieldOffset(0xA88)] public long SkillBarMessagePanel;
        //[FieldOffset(0xAC8)] public long Child0;
        //[FieldOffset(0xAD0)] public long RampageKillCountPanel;
        //[FieldOffset(0xAD8)] public long IncursionKillCountPanel;
        //[FieldOffset(0xAE0)] public long ZeroMustSurvivePanel;
        //[FieldOffset(0xAE8)] public long SyndicateNotifyPanel;
        //[FieldOffset(0xAF0)] public long SynthesisStabilizerProgressPanel;
        //[FieldOffset(0xAF8)] public long SynthesisRewardNotifyPanel;
        //[FieldOffset(0xB00)] public long RootNotifyPanel;
        //[FieldOffset(0xB08)] public long RoyaleWaitingForOthersPanel;
        //[FieldOffset(0xB10)] public long RoyaleNotifyPanel;
        //[FieldOffset(0xB18)] public long BlightProgressPanel;
        //[FieldOffset(0xB28)] public long Child14;
        //[FieldOffset(0xB30)] public long HeistNotifyPanel;
        //[FieldOffset(0xB38)] public long UltimatumReturnToRingNotifyPanel;
        //[FieldOffset(0xB48)] public long MissionRewardNotifyPanel;
        //[FieldOffset(0xB50)] public long ItemOnGroundTooltip;
        //[FieldOffset(0xB58)] public long Child138;
        //[FieldOffset(0xAA0)] public long MapTabWindowStartPtr; // AA0 is incorrect.
    }
}
