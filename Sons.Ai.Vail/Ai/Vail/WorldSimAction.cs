using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	[Serializable]
	public class WorldSimAction
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2B88580", Offset = "0x2B86B80", VA = "0x182B88580", Slot = "4")]
		public virtual Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		private void ShowButton()
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x20A0A60", Offset = "0x209F060", VA = "0x1820A0A60")]
		private void HideButton()
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
		public float GetWeight()
		{
			return 0f;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00006828 File Offset: 0x00004A28
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public bool ShouldShow
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x1700009E")]
		public bool ShouldShowSeason
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x2B88590", Offset = "0x2B86B90", VA = "0x182B88590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x2B885A0", Offset = "0x2B86BA0", VA = "0x182B885A0")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x2B88630", Offset = "0x2B86C30", VA = "0x182B88630")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x2B88670", Offset = "0x2B86C70", VA = "0x182B88670")]
		protected State GetState()
		{
			return default(State);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x1700009F")]
		protected virtual bool ShowStimuli
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x170000A0")]
		protected bool ShowStimuliValid
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x2B88690", Offset = "0x2B86C90", VA = "0x182B88690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x2B88730", Offset = "0x2B86D30", VA = "0x182B88730")]
		private void OnStimuliChanged()
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x2B88790", Offset = "0x2B86D90", VA = "0x182B88790")]
		protected static ValueDropdownList<string> GetStimuliTypes()
		{
			return null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x2B887E0", Offset = "0x2B86DE0", VA = "0x182B887E0")]
		protected Type GetStimuliType()
		{
			return null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "6")]
		public virtual Group ConvertToGroup()
		{
			return null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x2B88890", Offset = "0x2B86E90", VA = "0x182B88890", Slot = "7")]
		public virtual void Begin(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void End(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x2B88940", Offset = "0x2B86F40", VA = "0x182B88940", Slot = "9")]
		public virtual bool IsValid(VailWorldSimulation worldSim, WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x2B88A50", Offset = "0x2B87050", VA = "0x182B88A50", Slot = "10")]
		public virtual bool IsFinished(VailWorldSimulation worldSim, WorldSimActor actor, float startTimeHours)
		{
			return default(bool);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public virtual void OnConvertToVailActor(WorldSimActor worldActor, VailActor vailActor)
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void BeginListItem(WorldSimAction action, int opt)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void EndListItem(WorldSimAction action, int opt)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x2B88A80", Offset = "0x2B87080", VA = "0x182B88A80")]
		public WorldSimAction()
		{
		}

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _actionName;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private State _state;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public float _choiceWeight;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float _minDurationHours;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WorldSimAction.AreaType _areaCondition;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int _playerSentimentCondition;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2Int _hourOfDayRange;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _minDay;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _checkSeason;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SeasonsManager.Season _season;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public Vector2 _cooldownHoursRange;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Group _convertToGroup;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected string _stimuli;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public float _maxStimuliRange;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x88")]
		private Type _cachedStimuliType;

		// Token: 0x02000101 RID: 257
		[Token(Token = "0x2000101")]
		private enum AreaType
		{
			// Token: 0x040007D0 RID: 2000
			[Token(Token = "0x40007D0")]
			Any,
			// Token: 0x040007D1 RID: 2001
			[Token(Token = "0x40007D1")]
			Outside
		}
	}
}
