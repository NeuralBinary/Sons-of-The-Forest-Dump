using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[CreateAssetMenu(menuName = "Sons/Animation/Create MaeSequence", fileName = "MaeSequence", order = 0)]
	public class MaeSequence : ScriptableObject
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2D23470", Offset = "0x2D21A70", VA = "0x182D23470")]
		private void AddNewButton()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2D23480", Offset = "0x2D21A80", VA = "0x182D23480")]
		private void ClearSequencePool()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x17000012")]
		private bool IsPlaying
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2D23490", Offset = "0x2D21A90", VA = "0x182D23490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
		public bool HasEnded()
		{
			return default(bool);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
		public bool WasInterrupted()
		{
			return default(bool);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xAFE1F0", Offset = "0xAFC7F0", VA = "0x180AFE1F0")]
		public bool Failed()
		{
			return default(bool);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2D23510", Offset = "0x2D21B10", VA = "0x182D23510")]
		public bool SetInUse(bool value)
		{
			return default(bool);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public bool InUse
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2D23520", Offset = "0x2D21B20", VA = "0x182D23520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x2D23530", Offset = "0x2D21B30", VA = "0x182D23530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2D23540", Offset = "0x2D21B40", VA = "0x182D23540")]
		private ActionTemplate GetCurrentAction()
		{
			return null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2D235C0", Offset = "0x2D21BC0", VA = "0x182D235C0")]
		private IEnumerable GetAllActionTemplates()
		{
			return null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2D24260", Offset = "0x2D22860", VA = "0x182D24260")]
		private void BeginListItem(int opt)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2D242D0", Offset = "0x2D228D0", VA = "0x182D242D0")]
		private void EndListItem(int opt)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2D24340", Offset = "0x2D22940", VA = "0x182D24340")]
		private void AddItem()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2D24830", Offset = "0x2D22E30", VA = "0x182D24830")]
		public void Initialize(IMaeAnimator animator)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2D249F0", Offset = "0x2D22FF0", VA = "0x182D249F0")]
		public void Update()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2D24B20", Offset = "0x2D23120", VA = "0x182D24B20")]
		public bool AllowInterrupt()
		{
			return default(bool);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2D24B60", Offset = "0x2D23160", VA = "0x182D24B60", Slot = "4")]
		public virtual bool NoRootMotion()
		{
			return default(bool);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2D24B90", Offset = "0x2D23190", VA = "0x182D24B90")]
		public void SetInterrupted()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2D24BF0", Offset = "0x2D231F0", VA = "0x182D24BF0")]
		public void SetFailed()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2D24C00", Offset = "0x2D23200", VA = "0x182D24C00")]
		private void OnValidate()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2D24D50", Offset = "0x2D23350", VA = "0x182D24D50")]
		public string GetMessage()
		{
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public MaeSequence()
		{
		}

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _setNewActionTemplate;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private List<ActionTemplate> _actions;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x28")]
		private int _current;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x30")]
		private IMaeAnimator _target;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x38")]
		private bool _ended;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x39")]
		private bool _interrupted;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x3A")]
		private bool _failed;
	}
}
