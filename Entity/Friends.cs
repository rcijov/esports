using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Friends` (
    ///`idUser` int(11) NOT NULL,
    ///`idFriend` int(11) NOT NULL,
    ///PRIMARY KEY(`idFriend`) USING BTREE,
    ///KEY `FK_Friends_Users` (`idUser`),
    ///CONSTRAINT `FK_Friends_Users` FOREIGN KEY(`idUser`) REFERENCES `Users` (`idUser`) ON DELETE NO ACTION ON UPDATE NO ACTION
    ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class Friends
    {
        /// <summary>
        /// Foreign key of the user
        /// </summary>
        int idUser { get; set; }

        /// <summary>
        /// Primary key of the friend
        /// </summary>
        int idFriend { get; set; }

    }
}
