using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sons.UiElements
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class SonsSlider : Slider
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x315E150", Offset = "0x315C750", VA = "0x18315E150")]
		private int GetAxis()
		{
			return 0;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x315E160", Offset = "0x315C760", VA = "0x18315E160")]
		private bool GetReverseValue()
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x315E180", Offset = "0x315C780", VA = "0x18315E180", Slot = "31")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x315E460", Offset = "0x315CA60", VA = "0x18315E460")]
		public SonsSlider()
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float _stepSize;
	}
}
