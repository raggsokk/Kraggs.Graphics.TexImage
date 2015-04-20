///////////////////////////////////////////////////////////////////////////////////
/// OpenGL Image (gli.g-truc.net)
///
/// Copyright (c) 2008 - 2012 G-Truc Creation (www.g-truc.net)
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
///
/// @ref core
/// @file gli/core/format.hpp
/// @date 2012-10-16 / 2012-10-16
/// @author Christophe Riccio
///////////////////////////////////////////////////////////////////////////////////

using System;

namespace Kraggs.Graphics.TexImage
{
    /// <summary>
    /// In OpenGL speak, PixelType
    /// </summary>
    public enum GLITypeFormat
    {
        TYPE_NONE = 0,
        TYPE_I8 = 5120,
        TYPE_U8 = 5121,
        TYPE_I16 = 5122,
        TYPE_U16 = 5123,
        TYPE_I32 = 5124,
        TYPE_U32 = 5125,
        TYPE_F32 = 5126,
        TYPE_F16 = 5131,
        TYPE_UINT8_RG3B2 = 32818,
        TYPE_UINT16_RGBA4 = 32819,
        TYPE_UINT16_RGB5A1 = 32820,
        TYPE_UINT32_RGBA8 = 32821,
        TYPE_UINT32_RGB10A2 = 32822,
        TYPE_UINT8_RG3B2_REV = 33634,
        TYPE_UINT16_R5G6B5 = 33635,
        TYPE_UINT16_R5G6B5_REV = 33636,
        TYPE_UINT16_RGBA4_REV = 33637,
        TYPE_UINT16_RGB5A1_REV = 33638,
        TYPE_UINT32_RGBA8_REV = 33639,
        TYPE_UINT32_RGB10A2_REV = 33640,
        TYPE_UINT32_RG11B10F = 35899,
        TYPE_UINT32_RGB9_E5 = 35902,


        //TYPE_NONE = GLAllEnums.NONE,

        //TYPE_I8 = GLAllEnums.TYPE_I8,
        //TYPE_U8 = GLAllEnums.TYPE_U8,

        //TYPE_I16 = GLAllEnums.TYPE_I16,
        //TYPE_U16 = GLAllEnums.TYPE_U16,
        //TYPE_F16 = GLAllEnums.TYPE_F16,

        //TYPE_I32 = GLAllEnums.TYPE_I32,
        //TYPE_U32 = GLAllEnums.TYPE_U32,
        //TYPE_F32 = GLAllEnums.TYPE_F32,

        ////TYPE_F64 = GLAllEnums.

        //TYPE_UINT8_RG3B2 = GLAllEnums.TYPE_UINT8_RG3B2,
        //TYPE_UINT8_RG3B2_REV = GLAllEnums.TYPE_UINT8_RG3B2_REV,

        //TYPE_UINT16_RGBA4 = GLAllEnums.TYPE_UINT16_RGBA4,
        //TYPE_UINT16_RGBA4_REV = GLAllEnums.TYPE_UINT16_RGBA4_REV,

        //TYPE_UINT16_RGB5A1 = GLAllEnums.TYPE_UINT16_RGB5A1,
        //TYPE_UINT16_RGB5A1_REV = GLAllEnums.TYPE_UINT16_RGB5A1_REV,

        //TYPE_UINT16_R5G6B5 = GLAllEnums.TYPE_UINT16_R5G6B5,                
        //TYPE_UINT16_R5G6B5_REV = GLAllEnums.TYPE_UINT16_R5G6B5_REV,

        //TYPE_UINT32_RGBA8 = GLAllEnums.TYPE_UINT32_RGBA8,
        //TYPE_UINT32_RGBA8_REV = GLAllEnums.TYPE_UINT32_RGBA8_REV,

        //TYPE_UINT32_RGB10A2 = GLAllEnums.TYPE_UINT32_RGB10A2,
        //TYPE_UINT32_RGB10A2_REV = GLAllEnums.TYPE_UINT32_RGB10A2_REV,

        //TYPE_UINT32_RGB9_E5 = GLAllEnums.TYPE_UINT32_RGB9_E5,
        //// REV?
        //TYPE_UINT32_RG11B10F = GLAllEnums.TYPE_UINT32_RG11B10F,
        //// REV?


    }
}
