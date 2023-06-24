using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Ai.Vail.Memory;
using Sons.Animation.Mae;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[Serializable]
	public class Thought
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2B430E0", Offset = "0x2B416E0", VA = "0x182B430E0")]
		private string GetMuteButtonString()
		{
			return null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2B43130", Offset = "0x2B41730", VA = "0x182B43130")]
		private string GetIsolationButtonString()
		{
			return null;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x17000075")]
		public bool IsMuted
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x17000076")]
		public bool ShouldIsolate
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000077")]
		public string ThoughtMessage
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2B43180", Offset = "0x2B41780", VA = "0x182B43180")]
		internal void AddCondition()
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2B432B0", Offset = "0x2B418B0", VA = "0x182B432B0")]
		private string GetUnlessName()
		{
			return null;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2B43330", Offset = "0x2B41930", VA = "0x182B43330")]
		public bool SetMuteConditions(bool value)
		{
			return default(bool);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2B43340", Offset = "0x2B41940", VA = "0x182B43340")]
		private void MuteThought()
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2B43350", Offset = "0x2B41950", VA = "0x182B43350")]
		private void IsolateThought()
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x17000078")]
		private bool GameIsRunning
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x2B433A0", Offset = "0x2B419A0", VA = "0x182B433A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2B43420", Offset = "0x2B41A20", VA = "0x182B43420")]
		public Priority GetRunPriority(Priority priority, float thoughtTime)
		{
			return null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2B43580", Offset = "0x2B41B80", VA = "0x182B43580")]
		private ValueDropdownList<Group> GetGroupDropDown()
		{
			return null;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xECABE0", Offset = "0xEC91E0", VA = "0x180ECABE0")]
		private bool CheckIsStimuliQueryNone(IStimuliQuery target)
		{
			return default(bool);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2B437B0", Offset = "0x2B41DB0", VA = "0x182B437B0")]
		private bool IsStimuliQueryNone()
		{
			return default(bool);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2B437C0", Offset = "0x2B41DC0", VA = "0x182B437C0")]
		private void RefreshStimuliTarget()
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2B43A90", Offset = "0x2B42090", VA = "0x182B43A90")]
		private void UpdateStimuliQuery()
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2B43AA0", Offset = "0x2B420A0", VA = "0x182B43AA0")]
		private void UpdateQueryInternal(ref string stimuliQueryType, Type stimuliTarget, ref string stimuliSort, ref IStimuliQuery stimuliQuery)
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2B44330", Offset = "0x2B42930", VA = "0x182B44330")]
		private static IStimuliQuery GetInstance(Type queryType, Type stimuliType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterDelegate)
		{
			return null;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2B44790", Offset = "0x2B42D90", VA = "0x182B44790")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2B447D0", Offset = "0x2B42DD0", VA = "0x182B447D0")]
		public State GetStateChange()
		{
			return default(State);
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x17000079")]
		public bool ShouldChangeStateImmediately
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2B447F0", Offset = "0x2B42DF0", VA = "0x182B447F0")]
		private ValueDropdownList<string> GetStimuliSortActions()
		{
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2B44800", Offset = "0x2B42E00", VA = "0x182B44800")]
		internal void OnValidate(Group group)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2B44960", Offset = "0x2B42F60", VA = "0x182B44960")]
		public bool CanRun(VailActor actor, out IStimuli stimuli, ConditionSet conditionSet, bool muteConditions)
		{
			return default(bool);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2B44B20", Offset = "0x2B43120", VA = "0x182B44B20")]
		public bool ShouldInterruptByCondition(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2B44B40", Offset = "0x2B43140", VA = "0x182B44B40")]
		private bool ActorPassesConditions(VailActor actor, IStimuli stimuli, bool interruptCheck = false)
		{
			return default(bool);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public MaeSequence GetSequence()
		{
			return null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2B44CC0", Offset = "0x2B432C0", VA = "0x182B44CC0")]
		public string GetMessage()
		{
			return null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
		public float GetEnergyCost()
		{
			return 0f;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x20A0A60", Offset = "0x209F060", VA = "0x1820A0A60")]
		public void ClearIsolation()
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x5FD510", Offset = "0x5FBB10", VA = "0x1805FD510")]
		public void SetMute(bool value)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
		public List<Group> GetNextGroupsIds()
		{
			return null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x135A8E0", Offset = "0x1358EE0", VA = "0x18135A8E0")]
		public void SetAllGroupsMethod(Func<List<GroupListItem>> func)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2B44D20", Offset = "0x2B43320", VA = "0x182B44D20")]
		public MemoryEvent GetMemoryEvent()
		{
			return MemoryEvent.None;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x1700007A")]
		public int StatChosen
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xAFF3A0", Offset = "0xAFD9A0", VA = "0x180AFF3A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x1700007B")]
		public int StatInterrupted
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xAFF3C0", Offset = "0xAFD9C0", VA = "0x180AFF3C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2B44D30", Offset = "0x2B43330", VA = "0x182B44D30")]
		public void IncStat()
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2B44D40", Offset = "0x2B43340", VA = "0x182B44D40")]
		public void IncStatInterrupted()
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2B44D50", Offset = "0x2B43350", VA = "0x182B44D50")]
		private ValueDropdownList<string> GetStimuliTypes()
		{
			return null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x2B44DA0", Offset = "0x2B433A0", VA = "0x182B44DA0")]
		private bool ShouldHideStimuliSortType()
		{
			return default(bool);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2B44EE0", Offset = "0x2B434E0", VA = "0x182B44EE0")]
		private bool ShouldHideStimuliQueryType()
		{
			return default(bool);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2B44F50", Offset = "0x2B43550", VA = "0x182B44F50")]
		private bool IsDistanceStimuliQuery()
		{
			return default(bool);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2B44FD0", Offset = "0x2B435D0", VA = "0x182B44FD0")]
		private ValueDropdownList<string> GetStimuliQueryTypes()
		{
			return null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x2B45210", Offset = "0x2B43810", VA = "0x182B45210")]
		public Thought()
		{
		}

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		private const string EmptyThoughtMessage = "[No Message]";

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x10")]
		private bool _shouldIsolate;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x11")]
		private bool _mute;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_stimuliTarget")]
		[SerializeField]
		private string _stimuliTargetId;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x20")]
		private Type _stimuliTargetType;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stimuliQueryType;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x38")]
		[Header("Select:")]
		[SerializeField]
		private string _stimuliSort;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("_canSee")]
		[SerializeField]
		private bool _visibleCheck;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x48")]
		private IStimuliQuery _stimuliQuery;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x50")]
		[TextArea(2, 10)]
		[SerializeField]
		private string _thoughtMessage;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Thought.RunPriorityType _runPriority;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _runPriorityDelay;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _memoryEvent;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private MemoryEvent _memory;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x68")]
		private bool _muteConditions;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Condition> _conditions;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x78")]
		[Header("Mae Action:")]
		[SerializeField]
		private ThoughtAction _action;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x80")]
		[Header("Switch State:")]
		[SerializeField]
		private State _state;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool _switchStateImmediately;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[Header("Energy Cost:")]
		private float _energyCost;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<Group> _nextGroups;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0xB0")]
		private Func<List<GroupListItem>> _getAllGroupsFunction;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0xB8")]
		private int _statChosen;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0xBC")]
		private int _statInterrupted;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<Type, ValueDropdownList<string>> _filteredMenuLists;

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		private enum RunPriorityType
		{
			// Token: 0x04000577 RID: 1399
			[Token(Token = "0x4000577")]
			Same,
			// Token: 0x04000578 RID: 1400
			[Token(Token = "0x4000578")]
			Low,
			// Token: 0x04000579 RID: 1401
			[Token(Token = "0x4000579")]
			High,
			// Token: 0x0400057A RID: 1402
			[Token(Token = "0x400057A")]
			VeryHigh,
			// Token: 0x0400057B RID: 1403
			[Token(Token = "0x400057B")]
			Critical
		}
	}
}
