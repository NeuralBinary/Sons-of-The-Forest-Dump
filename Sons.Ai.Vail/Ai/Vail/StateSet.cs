using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Serializable]
	public class StateSet
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0xAC0A70", Offset = "0xABF070", VA = "0x180AC0A70")]
		private void ShowButton()
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0xAC0A80", Offset = "0xABF080", VA = "0x180AC0A80")]
		private void HideButton()
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2B34990", Offset = "0x2B32F90", VA = "0x182B34990")]
		private void SortGroupsGuiButton()
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2B34AF0", Offset = "0x2B330F0", VA = "0x182B34AF0")]
		private static string GetBackArrow()
		{
			return null;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00004D58 File Offset: 0x00002F58
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public bool ShouldShow
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x1700006A")]
		public bool BlockDriverOverride
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x1700006B")]
		public bool BlockAnyOverride
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x1700006C")]
		private Color GetSortColor
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x2B34B20", Offset = "0x2B33120", VA = "0x182B34B20")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2B34B40", Offset = "0x2B33140", VA = "0x182B34B40")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2B34990", Offset = "0x2B32F90", VA = "0x182B34990")]
		private void Sort()
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void BeginDrawGroupItem(int index)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2B34B80", Offset = "0x2B33180", VA = "0x182B34B80")]
		public StateSet()
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2B34C30", Offset = "0x2B33230", VA = "0x182B34C30")]
		public StateSet(State state)
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2B34F70", Offset = "0x2B33570", VA = "0x182B34F70")]
		public void OnValidate()
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2B35290", Offset = "0x2B33890", VA = "0x182B35290")]
		private void RefreshMoveUpAndDown()
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2B353F0", Offset = "0x2B339F0", VA = "0x182B353F0")]
		private Color InternalGetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x2B35480", Offset = "0x2B33A80", VA = "0x182B35480")]
		private string GetLabel()
		{
			return null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x2B35540", Offset = "0x2B33B40", VA = "0x182B35540")]
		public static Color GetStateButtonColor(State state)
		{
			return default(Color);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700")]
		public static Color GetStateColor(State state)
		{
			return default(Color);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xF47020", Offset = "0xF45620", VA = "0x180F47020")]
		public State GetState()
		{
			return default(State);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2B35630", Offset = "0x2B33C30", VA = "0x182B35630")]
		public List<GroupListItem> GetGroups()
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2B356F0", Offset = "0x2B33CF0", VA = "0x182B356F0")]
		public void CacheRuntimeGroupList(bool force = false)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2B35B20", Offset = "0x2B34120", VA = "0x182B35B20")]
		public bool Run(VailActor vailActor, Priority currentPriority, Priority interruptPriority, List<Group> nextInSequence, bool checkOverrides)
		{
			return default(bool);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2B35F30", Offset = "0x2B34530", VA = "0x182B35F30")]
		private bool RunNextSequence(VailActor vailActor, List<Group> nextInSequence)
		{
			return default(bool);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2B360B0", Offset = "0x2B346B0", VA = "0x182B360B0")]
		public bool RunGroup(VailActor vailActor, Group group)
		{
			return default(bool);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2B36360", Offset = "0x2B34960", VA = "0x182B36360")]
		private bool GroupExists(Group findGroup)
		{
			return default(bool);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2B36590", Offset = "0x2B34B90", VA = "0x182B36590")]
		private bool TryRunOverrideControllerAction(VailActor vailActor, bool isFollowingSequence, bool ignoreCurrentGroupScore, Priority matchPriority)
		{
			return default(bool);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2B36810", Offset = "0x2B34E10", VA = "0x182B36810")]
		private bool Run(VailActor vailActor, bool isFollowingSequence, bool ignoreCurrentGroupScore, Priority matchPriority, bool checkOverrides)
		{
			return default(bool);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2B36CE0", Offset = "0x2B352E0", VA = "0x182B36CE0")]
		private static void ShowDetailedChoiceLog(List<StateSet.ValidGroupInfo> allValid, int chosenIndex, float currentGroupScore, VailActor actor, string invalidGroupLog)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2B375E0", Offset = "0x2B35BE0", VA = "0x182B375E0")]
		public static float GetCurrentGroupScore(VailActor vailActor)
		{
			return 0f;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2B37770", Offset = "0x2B35D70", VA = "0x182B37770")]
		private List<StateSet.ValidGroupInfo> GetValidGroups(VailActor actor, Priority matchPriority, float currentGroupScore, out float total)
		{
			return null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2B37CB0", Offset = "0x2B362B0", VA = "0x182B37CB0")]
		public static float CalculateGroupScore(VailActor actor, Group eachGroup)
		{
			return 0f;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2B37D70", Offset = "0x2B36370", VA = "0x182B37D70")]
		private static float UpdateScoreFromDrivers(VailActor actor, List<StatDriver> drivers, float score)
		{
			return 0f;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2B37FF0", Offset = "0x2B365F0", VA = "0x182B37FF0")]
		private static float GetStatFactor(VailActor actor, StatDriver driver)
		{
			return 0f;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2B380C0", Offset = "0x2B366C0", VA = "0x182B380C0")]
		public bool CheckIsolation(out Group sender, out Thought result)
		{
			return default(bool);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2B383B0", Offset = "0x2B369B0", VA = "0x182B383B0")]
		public void ClearIsolation()
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2B38510", Offset = "0x2B36B10", VA = "0x182B38510")]
		public void SetMute(bool value)
		{
		}

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		private const float DefaultGroupDriverScore = 0.05f;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x10")]
		private readonly Priority[] _veryHighToLowPriorities;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private State _state;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x38")]
		[Header("Options")]
		[FormerlySerializedAs("_blockAny")]
		[SerializeField]
		private bool _blockAnyOverride;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _blockDriverOverride;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GroupListItem> _groupsList;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		private const float ForceThoughtScore = 1000f;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x48")]
		private bool _shouldShow;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x0")]
		private static List<StateSet.ValidGroupInfo> _validGroupList;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x50")]
		private List<Group>[] _runtimeGroupList;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x58")]
		private int _runtimeGroupListBuildLength;

		// Token: 0x0200009A RID: 154
		[Token(Token = "0x200009A")]
		private struct ValidGroupInfo
		{
			// Token: 0x0600064F RID: 1615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xF9F400", Offset = "0xF9DA00", VA = "0x180F9F400")]
			public ValidGroupInfo(Group inGroup, float inScore)
			{
			}

			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x400050C")]
			[FieldOffset(Offset = "0x0")]
			public Group Group;

			// Token: 0x0400050D RID: 1293
			[Token(Token = "0x400050D")]
			[FieldOffset(Offset = "0x8")]
			public float DriverScore;
		}
	}
}
