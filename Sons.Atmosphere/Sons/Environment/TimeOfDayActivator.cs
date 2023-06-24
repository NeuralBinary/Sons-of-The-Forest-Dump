using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class TimeOfDayActivator : TimeOfDayTrigger
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000008")]
		public override bool ShowEvents
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2D357A0", Offset = "0x2D33DA0", VA = "0x182D357A0", Slot = "9")]
		protected override void AwakeHook()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2D359E0", Offset = "0x2D33FE0", VA = "0x182D359E0")]
		private void ActivateObjects()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2D359F0", Offset = "0x2D33FF0", VA = "0x182D359F0")]
		private void DeactivateObjects()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2D35A00", Offset = "0x2D34000", VA = "0x182D35A00")]
		private void SetActivate(bool value)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2D35BF0", Offset = "0x2D341F0", VA = "0x182D35BF0")]
		public TimeOfDayActivator()
		{
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GameObject> _objectsToActivate;
	}
}
