#!/bin/bash
#
# RAGHU VARMA Build Script 
# Coded by RV 
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

clear

# Init Fields

Telegram_Api_code=
DRG=https://android.googleapis.com/packages/ota-api/nokia_drgsprout_dragon00ww/b3cd1383da3705b76f38687aaeb38aa8cc1962e3.zip
B2N=https://android.googleapis.com/packages/ota-api/nokia_b2nsprout_onyx00ww/5cee5d357ef514301a4e8def6f81ad0947a353fe.zip
PL2=https://android.googleapis.com/packages/ota-api/nokia_pl2sprout_plate200ww/bb7fea8687fc11e36c298f2b8e49c0116a174e11.zip
CTL=https://android.googleapis.com/packages/ota-api/nokia_ctlsprout_crystal00ww/2afb66e869bf61db5110c1c0c580b4dbd4408a6f.zip
DDV=https://android.googleapis.com/packages/ota-api/nokia_ddvsprout_daredevil00ww/34f88c8591e1f2d996a6d88578b03e5f8d7eadb1.zip
SLD=https://android.googleapis.com/packages/ota-api/nokia_sldsprout_starlord00ww/a452343dc669cc8b757340eb6988764e1e7b8a2b.zip
password=
path=/root

# Init Methods

DRG()
{
    mkdir DRG
    cd DRG
    wget $DRG
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/DRG/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "DRG" $path/rv5.txt)
    mv system.img sys.img
    mv vendor.img ven.img
    ./img2simg sys.img system.img
    ./img2simg ven.img vendor.img
    cp -r sys.img $path
    rm -r sys.img ven.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime sys.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/DRG/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/DRG/output
    cd
    cd $path/DRG/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/drg-sprout/STOCK-ROMS
    cd
    cd $path
    wget  https://github.com/RaghuVarma331/scripts/raw/master/pythonscripts/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia6plusofficial -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/drg-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.1 Plus*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia6plusofficial ✅" 
    umount system
    rm -r DRG system* rv5.txt sys.img
}    

B2N()
{
    mkdir B2N
    cd B2N
    wget $B2N
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/B2N/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "B2N" $path/rv5.txt)
    mv system.img sys.img
    mv vendor.img ven.img
    ./img2simg sys.img system.img
    ./img2simg ven.img vendor.img
    cp -r sys.img $path
    rm -r sys.img ven.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime sys.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/B2N/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/B2N/output
    cd
    cd $path/B2N/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/b2n-sprout/STOCK-ROMS
    cd
    cd $path
    wget  https://github.com/RaghuVarma331/scripts/raw/master/pythonscripts/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia7plusOfficial -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/b2n-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7 Plus*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia7plusOfficial ✅" 
    umount system
    rm -r B2N system* rv5.txt sys.img
}  

PL2()
{
    mkdir PL2
    cd PL2
    wget $PL2
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/PL2/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "PL2" $path/rv5.txt)
    mv system.img sys.img
    mv vendor.img ven.img
    ./img2simg sys.img system.img
    ./img2simg ven.img vendor.img
    cp -r sys.img $path
    rm -r sys.img ven.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime sys.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/PL2/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/PL2/output
    cd
    cd $path/PL2/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/pl2-sprout/STOCK-ROMS
    cd
    cd $path
    wget  https://github.com/RaghuVarma331/scripts/raw/master/pythonscripts/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @nokia7161 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/pl2-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.1*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @nokia7161 ✅" 
    umount system
    rm -r PL2 system* rv5.txt sys.img   
}  

CTL()
{
    mkdir CTL
    cd CTL
    wget $CTL
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/CTL/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "CTL" $path/rv5.txt)
    mv system.img sys.img
    mv vendor.img ven.img
    ./img2simg sys.img system.img
    ./img2simg ven.img vendor.img
    cp -r sys.img $path
    rm -r sys.img ven.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime sys.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/CTL/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/CTL/output
    cd
    cd $path/CTL/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/ctl-sprout/STOCK-ROMS
    cd
    cd $path
    wget  https://github.com/RaghuVarma331/scripts/raw/master/pythonscripts/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @nokia7161 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/ctl-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7.1*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @nokia7161 ✅" 
    umount system
    rm -r CTL system* rv5.txt sys.img
} 

DDV()
{
    mkdir DDV
    cd DDV
    wget $DDV
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/DDV/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin
    cp -r system.img $path
    cd
    cd $path
    mkdir system
    mount -o rw,noatime system.img system
    buildnumber=`cat system/system/build.prop | grep ro.build.version.incremental | cut -d "=" -f 2`
    if [ $(echo $buildnumber | cut -d "." -f 2) == 0 ]; then
    buildnumber=$(echo $buildnumber | cut -d "." -f 1)
    fi
    cd $path/DDV/payload
    mv system.img sys.img
    mv vendor.img ven.img
    ./img2simg sys.img system.img
    ./img2simg ven.img vendor.img
    rm -r sys.img ven.img
    cd
    cd $path
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi
    cd $path/DDV/payload
    zip -r DDV-$buildnumber-$androidversion.0-HB.zip *.img
    cp -r DDV-$buildnumber-$androidversion.0-HB.zip $path/DDV/output
    cd
    cd $path/DDV/output
    sshpass -p $password rsync -avP -e ssh DDV-$buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/ddv-sprout/STOCK-ROMS
    cd
    cd $path
    umount system
    wget  https://github.com/RaghuVarma331/scripts/raw/master/pythonscripts/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia7262 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/ddv-sprout/files/STOCK-ROMS/DDV-$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7.2*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia7262 ✅" 
    umount system    
    rm -r system* DDV system.img

}


SLD()
{
    mkdir SLD
    cd SLD
    wget $SLD
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/SLD/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin
    cp -r system.img $path
    cd
    cd $path
    mkdir system
    mount -o rw,noatime system.img system
    buildnumber=`cat system/system/build.prop | grep ro.build.version.incremental | cut -d "=" -f 2`
    if [ $(echo $buildnumber | cut -d "." -f 2) == 0 ]; then
    buildnumber=$(echo $buildnumber | cut -d "." -f 1)
    fi
    cd $path/SLD/payload
    mv system.img sys.img
    mv vendor.img ven.img
    ./img2simg sys.img system.img
    ./img2simg ven.img vendor.img
    rm -r sys.img ven.img
    cd
    cd $path
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi
    cd $path/SLD/payload
    zip -r SLD-$buildnumber-$androidversion.0-HB.zip *.img
    cp -r SLD-$buildnumber-$androidversion.0-HB.zip $path/SLD/output
    cd
    cd $path/SLD/output
    sshpass -p $password rsync -avP -e ssh SLD-$buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/sld-sprout/STOCK-ROMS
    cd
    cd $path
    umount system
    wget  https://github.com/RaghuVarma331/scripts/raw/master/pythonscripts/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia7262 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/sld-sprout/files/STOCK-ROMS/SLD-$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.2*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia7262 ✅" 
    umount system    
    rm -r system* SLD system.img
}


# Main Menu
clear
echo "-----------------------------------------------------------"
echo "A simple tool to make home brew stock rom from Full OTA.zip"
echo "Coded By Raghu Varma.G "
echo "-----------------------------------------------------------"
PS3='Please select your option (1-7): '
menuvar=("DRG" "B2N" "CTL" "PL2" "DDV" "SLD" "ALL" "Exit")
select menuvar in "${menuvar[@]}"
do
    case $menuvar in
        "DRG")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # DRG
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            DRG
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	    
        "B2N")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # B2N
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            B2N
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	
        "PL2")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # PL2
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            PL2
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	
        "CTL")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # CTL
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            CTL
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;		    
        "DDV")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # DDV
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            DDV
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;
        "SLD")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # SLD
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            SLD
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;
        "ALL")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # ALL
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            DRG
	    B2N
	    CTL
	    PL2
	    DDV
	    SLD
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;		    
        "Exit")
            break
            ;;
        *) echo Invalid option.;;
    esac
done   
            
